#include <iostream>
#include "bag.h"
using namespace std;

void bag::add(string file_name){
	for(int i=0;i<used;i++){
		if(file_name==data[i].get_fname()){
			data[i].set_count(data[i].get_count()+1);
			return;
		}
	}
	data[used].set_fname(file_name);
	data[used].set_count(1);
	used++;
	return;
}
	
int bag::get_size() const{
	return used;
}

void bag::print()const{
	for(int i=0;i<used;i++){
		cout<<"File: "<<data[i].get_fname()<<"; Count: "<<data[i].get_count()<<endl;
	}
	return;
}
