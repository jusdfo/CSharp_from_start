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
    //���ö˿ں�
    public const int port = 11000;
    public void StartListener()
    {
        UdpClient udpclient = new UdpClient(port);
        //������˵��ʾΪIP��ַ�Ͷ˿ں�
        IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Any, port);
        try
        {
            while (true)
            {
                byte[] bytes = udpclient.Receive(ref ipendpoint);
                string strIP = "��Ϣ����" + ipendpoint.Address.ToString();
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
        //��������ַ���ת��ΪIP��ַ
        IPAddress ipaddress = IPAddress.Parse(strServer);
        //�����͵����ݴ洢��byte������
        byte[] btContent = Encoding.GetEncoding("gb2312").GetBytes(strContent);
        IPEndPoint ipendpoint = new IPEndPoint(ipaddress, 11000);
        socket.SendTo(btContent, ipendpoint);
        socket.Close();
        return "���ͳɹ�";
    }
}
