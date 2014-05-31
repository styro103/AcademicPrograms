sprintf(message, "Message of holiday from process %d", my_rank);

//works for even #CPU   
 if (p%2==0){
   if (my_rank==0){
      MPI_Send(message, strlen(message)+1, MPI_CHAR, 2, tag, MPI_COMM_WORLD);
   MPI_Recv(message, 100, MPI_CHAR, p-2, tag, MPI_COMM_WORLD, &status);
   }
   else if (my_rank==p-2) {
       MPI_Send(message, strlen(message)+1, MPI_CHAR, 0, tag, MPI_COMM_WORLD);
   MPI_Recv(message, 100, MPI_CHAR, my_rank-2, tag, MPI_COMM_WORLD, &status);
   }
   else if (my_rank%2==0 && my_rank<p-1 ){
      MPI_Send(message, strlen(message)+1, MPI_CHAR, my_rank+2, tag, MPI_COMM_WORLD);
   MPI_Recv(message, 100, MPI_CHAR, my_rank-2, tag, MPI_COMM_WORLD, &status);
   }
  if (my_rank==1){
 MPI_Send(message, strlen(message)+1, MPI_CHAR, p-1, tag, MPI_COMM_WORLD);
   MPI_Recv(message, 100, MPI_CHAR, my_rank+2, tag, MPI_COMM_WORLD, &status);
   }
   else if (my_rank==p-1) {
       MPI_Send(message, strlen(message)+1, MPI_CHAR, p-3, tag, MPI_COMM_WORLD);
   MPI_Recv(message, 100, MPI_CHAR, 1, tag, MPI_COMM_WORLD, &status);//myrank_2
   }
    else if (my_rank%2!=0 && my_rank<p-1 ){
      MPI_Send(message, strlen(message)+1, MPI_CHAR, my_rank-2, tag, MPI_COMM_WORLD);
   MPI_Recv(message, 100, MPI_CHAR, my_rank+2, tag, MPI_COMM_WORLD, &status);
   }}