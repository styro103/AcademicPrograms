import java.net.*;
import java.io.*;
import java.util.Date;

public class simpleServer {
    public final static int port = 8080;

    public static void main(String[] args) {
        ServerSocket theServer;
        Socket theConnection;
        PrintStream p;

        try {
            theServer = new ServerSocket(port);
            try {
                while (true) {
                theConnection = theServer.accept();
                p = new PrintStream(theConnection.getOutputStream());
                p.println(new Date());
                theConnection.close();
                }
            }
            catch (IOException e) {
                theServer.close();
                System.err.println(e);
            }
        }
        catch (IOException e) {
            System.err.println(e);
        }
    }

}
