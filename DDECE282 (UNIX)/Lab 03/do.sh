#!/bin/bash
#Shaun Mbateng
#Lab 3
#ECE282 Unix
#This Script Works Like A Double Click
#	and Opens Up Inputted File

FILENAME=$(basename $1)
EXTENSION="${FILENAME##*.}" 							#Gets Extension of Input
FILENAME="${FILENAME%.*}" 								#Gets Filename of Input

if [ -s $1 ]; then 									#If File Exists
	CONFIG="/export/home1/smbateng/.dorc" 					#Check .dorc File
	while IFS= read -r LINE 							#Read Line by Line
	do
		if [ "$LINE" != "" ]; then 						#If LINE Isn't Empty
			VAR1=`echo "$LINE" |cut -c1` 				#Make VAR1 the First Character of the Line
			if [ "$VAR1" != "#" ]; then 				#If First Character is '#' Symbol
				VAR2=`echo "$LINE" |cut -d " " -f2` 		#Make VAR2 the Second Field of Line (Lists Extension)
				VAR3=`echo "$LINE" |cut -d " " -f3` 		#Make VAR3 the Third Field of Line (Lists How to Open)
				if [ "$EXTENSION" = "$VAR2" ]; then 		#If VAR2 Matches Input's Extension
					"$VAR3" $1 					#Open Using f3
				fi 							#End If Statement
			fi 								#End If Statement
		fi 									#End If Statement
	done <"$CONFIG" 								#End While Loop
else
	echo "File Doesn't Exist" 							#Else State That the File Doesn't Exist
fi 											#End If Statement




