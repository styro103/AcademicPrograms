import java.io.*;
import java.net.*;

class TCPserver{

    public static void main (String argv[]) throws Exception {
        String clientSentence;
        String modifiedSentence;

        ServerSocket sSocket = new ServerSocket(8004);
        while(true) {
            Socket conn = sSocket.accept();
            BufferedReader inFromClient = new BufferedReader(new InputStreamReader(conn.getInputStream()));
            DataOutputStream outToClient = new DataOutputStream(conn.getOutputStream());
            clientSentence = inFromClient.readLine();
            modifiedSentence = clientSentence.toUpperCase() + "\n";
            outToClient.writeBytes(modifiedSentence);            
        }
    }
}
