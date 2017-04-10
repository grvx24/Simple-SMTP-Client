using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Smtp_client_WindowMode
{
    
    public partial class Form1 : Form
    {
        private TcpClient client=null;
        private bool connected = false;
        public StreamReader STR;
        public StreamWriter STW;
        public string received_text;
        public string text_to_send;
        private string from;
        private string to;


        private bool helo = false;
        private bool logged_in = false;
        private string clientIP;
        private string username="";
        private string password = "";

        //plik
        private byte[] buffer = null;
        int bufferSize = 1024;
        int bufferCount;
        string filePath = "";
        private bool has_file = false;
        private byte[] fileBytes;
        private int fileSize = 0;
        private string fileName = "";

        private bool sending_file = false;


        public Form1()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    clientIP = address.ToString();
                }
            }
        }

        private void SetFileBytes(string path)
        {
            fileBytes = null;
            try
            {
                fileBytes = File.ReadAllBytes(path);
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void ConnectButton_Click(object sender, EventArgs e) //Connect to server
        {
            if (Regex.IsMatch(IP_TextBox.Text, @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")&& !connected)
            {
                client = new TcpClient();
                IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(IP_TextBox.Text), int.Parse(Port_TextBox.Text));
                try
                {
                    client.Connect(IP_End);                   
                    if (client.Connected)
                    {
                        connected = true;
                        MainConsole.AppendText("Connected \n");
                        STW = new StreamWriter(client.GetStream());
                        STR = new StreamReader(client.GetStream());
                        STW.AutoFlush = true;
                        backgroundWorker1.RunWorkerAsync();

                       
                    }
                }
                catch (Exception exc)
                {
                    backgroundWorker1.CancelAsync();
                    MessageBox.Show(exc.Message.ToString());
                }
            }
            else
            {
                if (connected)
                    MessageBox.Show("Already connected");
                else
                    MessageBox.Show("Wrong IP Address");
            }

        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(client.Connected)
            {
                try
                {
                    received_text = STR.ReadLine();

                    //haslo
                    if(received_text=="250 User Ok")
                    {
                        STW.WriteLine("pass " + password);
                    }

                    if(received_text=="250 Pass Ok")
                    {
                        logged_in = true;
                    }


                    if(received_text== "250 Ok")
                    {
                        
                        STW.WriteLine("rcpt to: " + "<"+to+">");
                    }

                    if(received_text== "250 Accepted")
                    {
                        
                        STW.WriteLine("data");
                    }

                    if (received_text == ("354 Ok Send data"))
                    {
                        
                        STW.WriteLine("From: " + SenderTextBox.Text);
                        STW.WriteLine("To: " + ReceiverTextBox.Text);
                        STW.WriteLine("Subject: " + SubjectTextBox.Text);
                        STW.WriteLine(DataTextBox.Text);
                        if (!has_file)
                        { 
                            STW.WriteLine(".");
                            STW.WriteLine("No files");
                        }
                        else
                        {
                            STW.WriteLine(".");
                            STW.WriteLine("Size "+fileBytes.Length.ToString());
                        }



                    }
                  
                    if (received_text== "250 Size Ok")
                    {
                        
                        STW.WriteLine("FileName " + fileName);
                    }

                    if (received_text== "250 Ready")
                    {
                        sending_file = true;

                        if (sending_file)
                        {
                            this.MainConsole.Invoke(new MethodInvoker(delegate () { MainConsole.AppendText(received_text + "\n"); }));
                            received_text = "";
                            var stream = client.GetStream();
                            FileStream fs = new FileStream(filePath, FileMode.Open);

                            //bufferCount = Convert.ToInt32(Math.Ceiling((double)fs.Length / (double)bufferSize));

                            //teraz niepotrzebne
                            //for (int i = 0; i < bufferCount; i++)

                                buffer = new byte[bufferSize];
                                int size = fs.Read(buffer, 0, bufferSize);

                                client.Client.Send(fileBytes, fileSize, SocketFlags.Partial);
                                

                            fs.Close();
                            sending_file = false;
                        }

                    }



                    this.MainConsole.Invoke(new MethodInvoker(delegate () { MainConsole.AppendText(received_text + "\n"); }));
                    if(!helo)
                    {
                        STW.WriteLine("helo " + clientIP);
                        helo = true;
                    }

                    received_text = "";

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message.ToString());
                }
            }
        }



        private void SendButton_Click(object sender, EventArgs e) //Send button
        {
            if (logged_in)
            {
                from = SenderTextBox.Text;
                to = ReceiverTextBox.Text;

                bool isEmail1 = Regex.IsMatch(from, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                bool isEmail2 = Regex.IsMatch(to, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);


                if (isEmail1&&isEmail2)
                {
                    if (client.Connected)
                    {
                        STW.WriteLine("mail from: " + "<"+from+">");

                    }
                    else
                    {
                        MessageBox.Show("Sending failed");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong email address");
                }
            }
            else
            {
                MessageBox.Show("Log in first");
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)  //log in
        {
            username = UsernameBox.Text;
            password = PasswordBox.Text;

            if(client.Connected)
            {
                STW.WriteLine("user "+username);
            }


        }

        private void BrowseButton_Click(object sender, EventArgs e)//file
        {
            DialogResult result=openFileDialog1.ShowDialog();
            if(result==DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                SetFileBytes(filePath);
                fileName = Path.GetFileName(filePath);
                fileSize = fileBytes.Length;
                FileTextBox.Text = filePath;
                FileSizeBox.Text = fileSize.ToString()+" bytes";
                has_file = true;

                
            }
        }

        private void ClearFileButton_Click(object sender, EventArgs e)
        {
            fileBytes = null;
            FileTextBox.Text = "No file";
            FileSizeBox.Text = "0";
            has_file = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FileSizeBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
