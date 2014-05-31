#include "prj.h"
#include "pr1.h"

struct word *addNewWordsToQ(struct word *head,struct word *newWordsHead);
struct word *process_myQ (struct word * head);
void 	display_myQ (struct word *head);
struct word *matchWord(struct word *head,char *input);
void delete_word (struct word * messageToGo);
struct word * delete_LinesOfWords(struct  word *head,  int lines);
void display_Statistics();
void 	appTerminate (struct word *head);
void 	free_list(struct word *head);
void set_priority (struct word *head,  int newPriority);

struct word * sortWordList(struct word *head);

