#include "word.h"
#include <iostream>
using namespace std;


string Word::get_word(){
        return word_name;
}
void Word::set_word(string word){
	word_name=word;
}
void Word::printing(){
	file_bag.print();
}
void Word::addition(string file_name){
	file_bag.add(file_name);
}