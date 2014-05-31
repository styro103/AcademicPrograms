#include <iostream>
using namespace std;

int main () {

	long int sum = 0;
	for (long int x = 1; x < 300000; x++)
		sum += x;
	
	cout << sum << endl;

	return 0;
}
