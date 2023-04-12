using System;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
	}
    //设置端口号
    public const int port = 11000;
    public void StartListener()
    {
        UdpClient udpclient = new UdpClient(port);
        //将网络端点表示为IP地址和端口号
        IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Any, port);
        try
        {
            while (true)
            {
                byte[] bytes = udpclient.Receive(ref ipendpoint);
                string strIP = "信息来自" + ipendpoint.Address.ToString();
                string strInfo = Encoding.GetEncoding("gb2312").GetString(bytes, 0, bytes.Length);
                MessageBox.Show(strInfo, strIP);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
        }
        finally
        {
            udpclient.Close();
        }
    }
    public string Send(string strServer,string strContent)
    {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        //将输入的字符串转换为IP地址
        IPAddress ipaddress = IPAddress.Parse(strServer);
        //将发送的内容存储到byte数组中
        byte[] btContent = Encoding.GetEncoding("gb2312").GetBytes(strContent);
        IPEndPoint ipendpoint = new IPEndPoint(ipaddress, 11000);
        socket.SendTo(btContent, ipendpoint);
        socket.Close();
        return "发送成功";
    }
}
