#ifndef WORD_H
#define WORD_H
using namespace std;
#include <string>
#include "bag.h"

class Word
{
	public:
		
		string get_word();
		void printing();
		void addition(string file_name);
		void set_word(string word);

	private:
		string word_name;
		bag file_bag;
};
#endif