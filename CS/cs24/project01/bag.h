#ifndef BAG_H
#define BAG_H
#include <iostream>
#include "itemtype.h"
#include <string>
using namespace std;

class bag{
	public:
		Bag(){used=0;}
		void add(string file_name);
		
		void print() const;//print the list of files and counts
		
		int get_size() const;
		
	
	private:
		File data[100];
		int used;
	
	
};
#endif