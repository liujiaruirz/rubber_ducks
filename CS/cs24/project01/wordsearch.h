#ifndef WORDSEARCH_H
#define WORDSEARCH_H
#include <iostream>
#include "bag.h"


int getdir (string dir, vector<string> &files);
void word_search(string word,Word word_array[],int length);
void update_word_array(string word, Word word_array[],int& length,string file);









#endif