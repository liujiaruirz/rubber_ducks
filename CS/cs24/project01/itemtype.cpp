
#include "itemtype.h"
#include <string>
using namespace std;



int File::get_count()const{
	return count;

}
void File::set_count(int freq){
	count=freq;
	
}
string File::get_fname() const{
	return fname;
}
void File::set_fname(string file_name){
	fname=file_name;
}
