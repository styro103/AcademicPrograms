# Shaun Mbateng
# CS 441 - Sorenson
# Scripting Project Part 1
# This part replaces all spaces in directory's files with underscores

echo "";
echo "***Replacing Blanks With Underscores***";
echo "";
for file in *;
do 
	mv "$file" "${file/ /_}";
done

# smbateng@thomas(11:44:46)~/Files/CS441 (Multiple Lanugages)/sample>ls
# nospace.txt  underscore.sh  yes space.txt
# smbateng@thomas(11:44:50)~/Files/CS441 (Multiple Lanugages)/sample>underscore.sh
    
# ***Replacing Blanks With Underscores***

# mv: `nospace.txt' and `nospace.txt' are the same file
# mv: `underscore.sh' and `underscore.sh' are the same file
# smbateng@thomas(11:45:04)~/Files/CS441 (Multiple Lanugages)/sample>ls
# nospace.txt  underscore.sh  yes_space.txt
# smbateng@thomas(11:45:10)~/Files/CS441 (Multiple Lanugages)/sample>
