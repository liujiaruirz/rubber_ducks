CXX=g++
wordsearch:word.o bag.o itemtype.o wordsearch.o
	$(CXX) wordsearch.o word.o itemtype.o bag.o -o wordsearch
bag.o:bag.cpp bag.h itemtype.h
	$(CXX) -c bag.cpp
itemtype.o:itemtype.cpp itemtype.h
	$(CXX) -c itemtype.cpp
word.o:word.cpp word.h
	$(CXX) -c word.cpp
wordsearch.o:wordsearch.cpp wordsearch.h 
word.h
	$(CXX) -c wordsearch.cpp
clean:
	rm main bag.o itemtype.o word.o wordsearch.o
	
