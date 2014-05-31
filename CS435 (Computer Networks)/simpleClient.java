iimport java.io.*;
import java.net.*;
 
public class simpleClient {
 
	public static String host = "www.google.com";
	public static int port = 80;
	
	public static void main(String[] args) {
		try {
			InetAddress addr = InetAddress.getByName(host);
 
			// This constructor will block until the connection succeeds
			Socket socket = new Socket(addr, port);
		} catch (UnknownHostException e) {
		} catch (IOException e) {
		}
 
		// Create a socket with a timeout
		try {
			InetAddress addr = InetAddress.getByName(host);
			SocketAddress sockaddr = new InetSocketAddress(addr, port);
 
			// Create an unbound socket
			Socket sock = new Socket();
 
			// This method will block no more than timeoutMs.
			// If the timeout occurs, SocketTimeoutException is thrown.
			int timeoutMs = 2000;   // 2 seconds
			sock.connect(sockaddr, timeoutMs);
		    BufferedWriter wr = new BufferedWriter(new OutputStreamWriter(sock.getOutputStream()));
		    BufferedReader rd = new BufferedReader(new InputStreamReader(sock.getInputStream()));
		    wr.write("GET / HTTP/1.1\nHost: "+host+"\nConnection: close\n\n");
		    wr.flush();
		    String str;
		    while ((str = rd.readLine()) != null) {
		        System.out.println(str);
		    }
		    rd.close();
		} catch (UnknownHostException e) {
		} catch (SocketTimeoutException e) {
		} catch (IOException e) {
		}
	} // end of main
 
} // end of class
