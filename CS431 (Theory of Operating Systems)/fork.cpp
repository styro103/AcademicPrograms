#include <sys/types.h>
#include <sys/wait.h>
#include <iostream>
#include <cstdlib>
#include <unistd.h>

using namespace std;

int main()
{
  int status = 0;
  pid_t pid;

  /* fork a child process */
  pid = fork();

  if(pid < 0) { /* error scenario */
    cerr << "fork() failed\n" << endl;
    exit(-1);
  }
  else if (pid == 0) { /* child process */
    execlp("/bin/ps", "ps", NULL);
  }
  else { /* parent process */
    /* parent will wait for child to complete */
    wait(&status);
    cout << "\nChild complete\n" << endl;
    exit(0);
  }
}

