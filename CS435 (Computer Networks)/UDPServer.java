import java.io.*;
import java.net.*;

class UDPServer {
    public static void main(String args[]) throws Exception {
	    DatagramSocket serverSocket = new DatagramSocket(9876);
		byte[] sendData = new byte[1024];
		byte[] recvData = new byte[1024];
        while(true) {
		    DatagramPacket recvPacket = new DatagramPacket(recvData, recvData.length);
		    serverSocket.receive(recvPacket);
		    String message = new String(recvPacket.getData());
		    System.out.println("FROM CLIENT: " + message);
            InetAddress IPAddress = recvPacket.getAddress();
			int port = recvPacket.getPort();
			String response = message.toUpperCase();
			sendData = response.getBytes();
			DatagramPacket sendPacket = new DatagramPacket(sendData, sendData.length, IPAddress, port);
			serverSocket.send(sendPacket);
		}
	}
}