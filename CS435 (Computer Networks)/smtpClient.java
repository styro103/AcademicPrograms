import java.io.*;
import java.net.*;

class smtpClient{

    private static String host = "donna.butler.edu";
    private static int port = 25;

    public static void main (String argv[]) throws Exception {
        String message;
        String response;
        
        // to get user input
        BufferedReader inFromUser = new BufferedReader(new InputStreamReader(System.in));

        Socket clientSocket = new Socket(host, port);
        DataOutputStream outToServer = new DataOutputStream(clientSocket.getOutputStream());
        BufferedReader inFromServer = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));
        
        // get our message data
        System.out.print("Enter the FROM address: ");
        String fromAddr = inFromUser.readLine();
        System.out.print("Enter the RECIPIENT address: ");
        String rcptAddr = inFromUser.readLine();
        System.out.print("Enter the SUBJECT: ");
        String subject = inFromUser.readLine();
        System.out.print("Enter the MESSAGE: ");
        String msg = inFromUser.readLine();

        response = inFromServer.readLine();
        System.out.println("FROM SERVER: "+response);

        outToServer.writeBytes("HELO thomas.butler.edu\n");
        response = inFromServer.readLine();
        System.out.println("FROM SERVER: "+response);

        outToServer.writeBytes("MAIL FROM: <" + fromAddr + ">\n");
        response = inFromServer.readLine();
        System.out.println("FROM SERVER: "+response);

        outToServer.writeBytes("RCPT TO: <" + rcptAddr + ">\n");
        response = inFromServer.readLine();
        System.out.println("FROM SERVER: "+response);

        outToServer.writeBytes("DATA\n");
        response = inFromServer.readLine();
        System.out.println("FROM SERVER: "+response);

        outToServer.writeBytes("To: "+rcptAddr+"\nFrom: "+ fromAddr +"\n");
        outToServer.writeBytes("Subject: "+subject+"\n"+ msg +"\n");
        outToServer.writeBytes(".\n");
        response = inFromServer.readLine();
        System.out.println("FROM SERVER: "+response);

        outToServer.writeBytes("QUIT\n");
        response = inFromServer.readLine();
        System.out.println("FROM SERVER: "+response);
        // clientSocket.close();
    }
}
