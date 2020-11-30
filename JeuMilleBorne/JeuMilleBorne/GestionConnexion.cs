using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuMilleBorne
{
    public class GestionConnexion
    {
        public static NetworkStream fluxNetworkStream;
        private static int _port = 8000;
        public static TcpListener tlServer;
        public static TcpClient TcpClient;
        public static BinaryReader br;
        public static BinaryWriter bw;

        private static IPAddress adresseValidee(string nPC)
        {
            IPAddress ipReponse = null;

            if (nPC.Length > 0)
            {
                IPAddress[] ipServer = Dns.GetHostEntry(nPC).AddressList;
                for (int i = 0; i < ipServer.Length; i++)
                {
                    Ping pingServer = new Ping();
                    PingReply pingReponse = pingServer.Send(ipServer[i]);
                    if (pingReponse.Status == IPStatus.Success)
                    {
                        if (ipServer[i].AddressFamily == AddressFamily.InterNetwork)
                        {
                            //MessageBox.Show(ipServer[i].ToString());
                            ipReponse = ipServer[i];
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Renseigner le nom de la machine!");
            }


            return ipReponse;
        }
        #region OldVersion

        //public static Socket _Server, _Client;
        //private static int _port = 8000, _Flag = 0;
        //public static byte[] _Buffer, _DatasBytes;// = new byte[256]

        //public GestionConnexion()
        //{

        //}


        //public static void SocketEcouter()
        //{
        //    _Flag = 1;
        //    _Client = null;
        //    IPAddress _IPServer = adresseValidee(Dns.GetHostName());
        //    _Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //    _Server.Bind(new IPEndPoint(_IPServer, _port));
        //    _Server.Listen(1);
        //    _Server.BeginAccept(new AsyncCallback(ClientConnexion), _Server);
        //}

        //private static void ClientConnexion(IAsyncResult iar)
        //{
        //    if (_Flag == 1)
        //    {
        //        Socket tmp = (Socket)iar.AsyncState;
        //        _Client = tmp.EndAccept(iar);
        //        _Client.Send(Encoding.Unicode.GetBytes("Connexion acceptée..."));

        //        //InsererItemThread("Connexion effectuée par " + ((IPEndPoint)_Client.RemoteEndPoint).Address.ToString());
        //        MessageBox.Show("Connexion effectuée par " + ((IPEndPoint)_Client.RemoteEndPoint).Address.ToString());
        //        InitialiserReception(_Client);
        //    }
        //}
        //private static void InitialiserReception(Socket soc)
        //{
        //    // modifié
        //    _Buffer = new byte[3500];
        //    soc.BeginReceive(_Buffer, 0, _Buffer.Length, SocketFlags.None, new AsyncCallback(Reception), soc);
        //    fluxNetworkStream =
        //}
        //private static void Reception(IAsyncResult iar)
        //{
        //    if (_Flag > 0)
        //    {
        //        Socket tmp = (Socket)iar.AsyncState;
        //        int recu = tmp.EndReceive(iar);
        //        if (recu > 0)
        //        {
        //            //InsererItemThread(Encoding.Unicode.GetString(_Buffer));
        //            _DatasBytes = _Buffer;
        //            MessageBox.Show(Encoding.Unicode.GetString(_Buffer));
        //            //_Buffer = Array.Empty<byte>();
        //            InitialiserReception(tmp);
        //        }
        //        else
        //        {
        //            tmp.Disconnect(true);
        //            tmp.Close();
        //            _Server.BeginAccept(new AsyncCallback(ClientConnexion), _Server);
        //            _Client = null;
        //        }
        //    }
        //}
        //public static void Connecter(string server)
        //{
        //    if (server.Length > 0)
        //    {

        //        _Flag = 2;

        //        _Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //        _Client.Blocking = false;
        //        IPAddress ipServer = adresseValidee(server);
        //        _Client.BeginConnect(new IPEndPoint(ipServer, _port), new AsyncCallback(SurConnexion), _Client);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Indiquer un serveur.");
        //    }
        //}
        //private static void SurConnexion(IAsyncResult iar)
        //{
        //    Socket tmp = (Socket)iar.AsyncState;
        //    if (tmp.Connected)
        //    {
        //        InitialiserReception(tmp);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Serveur inaccessible...");
        //    }

        //}
        //private static void mcSocketDeconnecter_Click(object sender, EventArgs e)
        //{
        //    if (_Flag == 2)
        //    {
        //        _Client.Send(Encoding.Unicode.GetBytes("Déconnexion (client)"));
        //        _Client.Shutdown(SocketShutdown.Both);
        //        _Flag = 0;
        //        _Client.BeginDisconnect(false, new AsyncCallback(DemandeDeconnexion), _Client);
        //    }
        //    else
        //    {
        //        if (_Client == null)
        //        {
        //            _Server.Close();
        //            _Flag = 0;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Client connecté, pas de déconnexion");
        //        }
        //    }
        //}
        //private static void DemandeDeconnexion(IAsyncResult iar)
        //{
        //    Socket tmp = (Socket)iar.AsyncState;
        //    tmp.EndDisconnect(iar);
        //}

        //public static void SendData(byte[] bufferBytes)
        //{
        //    _Client.Send(bufferBytes);
        //}
        ////#region Mode Debug

        ////delegate void RenvoiVersInserer(string sTexte);

        ////private void InsererItemThread(string sTexte)
        ////{
        ////    Thread threadInsererItem = new Thread(new ParameterizedThreadStart(InsererItem));
        ////    threadInsererItem.Start(sTexte);
        ////}

        ////private void InsererItem(object oTexte)
        ////{
        ////    if (lbEchange.InvokeRequired)
        ////    {
        ////        RenvoiVersInserer f = new RenvoiVersInserer(InsererItem);
        ////        Invoke(f, new object[] { (string)oTexte });
        ////    }
        ////    else
        ////    {
        ////        lbEchange.Items.Add((string)oTexte);
        ////    }
        ////}
        ////#endregion


        #endregion

        #region NewVersion

        public async Task Server()
        {
            try
            {
                /* () méthode anonyme */
                await Task.Run(() =>
                {
                    IPAddress ipServer = adresseValidee(Dns.GetHostName());
                    tlServer = new TcpListener(ipServer, _port);
                    tlServer.Start();
                    TcpClient = tlServer.AcceptTcpClient();
                    fluxNetworkStream = TcpClient.GetStream();

                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        public async Task Client(string serverHostName)
        {
            try
            {
                /* () méthode anonyme */
                await Task.Run(() =>
                {
                    IPAddress ipServer = adresseValidee(serverHostName);
                    TcpClient = new TcpClient();
                    TcpClient.Connect(ipServer, _port);
                    fluxNetworkStream = TcpClient.GetStream();
                });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<bool> SendData<T>(T sendObject )
        {
            try
            {
                await Task.Run(() =>
                {
                    BinaryWriter binaryWriter = new BinaryWriter(fluxNetworkStream);

                    byte[] dataBytes = SerializeDataNetwork.SendData(SerializeDataNetwork.GetFieldValues(sendObject));

                    binaryWriter.Write(dataBytes);
                });
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public void CloseClient()
        {
            TcpClient.Close();
        }
        public void CloseConnection()
        {
            TcpClient.Close();
            tlServer.Stop();
        }
        #endregion

        #region Ping

        public async Task<string[]> fPing()
        {
            List<Task<string>> tasks = new List<Task<string>>();

            for (int i = 1; i < 255; i++)
            {
                string ip = "192.168.1." + i.ToString();
                //PingReply pingReponse = await ;
                tasks.Add(PingTask(ip));
            }

            var res = await Task.WhenAll(tasks);

            //foreach (var hostname in res)
            //{
            //    if (hostname != null)
            //    {
            //        FicAccueil.cb .Items.Add(hostname);
            //    }
            //}

            MessageBox.Show("Scan terminé");
            return res;
        }

        public Task<string> PingTask(string ip)
        {
            return Task.Run(() => Ping(ip)).ContinueWith(task =>
            {
                IPHostEntry repEntry = null;

                if (task.Result.Status == IPStatus.Success)
                {
                    repEntry = Dns.GetHostEntry(task.Result.Address);
                }
                //? permet de renvoyer null ou le hostname \\
                return repEntry?.HostName.ToString();
            });
        }

        public async Task<PingReply> Ping(string ip)
        {
            Ping pingServer = new Ping();
            PingReply rep = await pingServer.SendPingAsync(ip, 100);
            return rep;
        }
        #endregion

    }
}
