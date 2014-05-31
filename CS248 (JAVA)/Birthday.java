import java.util.GregorianCalendar;
//import java.lang.String;
//import java.util.Scanner;
import java.io.*;
import java.util.*;

/** Program that asks for your date of birth, then displays the weekday
* that you were born on (i.e., Sunday through Saturday)*/

class Birthday
{
	public static void main(String [] args)
	{   
		//Obtain the year of birth
		System.out.println("What year were you born in?");
		Scanner keyboard = new Scanner(System.in);
		String varYear = keyboard.next();

		int year = Integer.parseInt( varYear );

		//Obtain the month of birth

		System.out.println("What month were you born in? (Please type in ALL CAPS)");
		Scanner keyboard2 = new Scanner(System.in);
		String month = keyboard2.next();

		//Obtain the day of the month of birth

		System.out.println("What date of the month were you born on?");
		Scanner keyboard3 = new Scanner(System.in);
		String varDay = keyboard3.next();

		int day = Integer.parseInt( varDay );

		//========== Calculate day of birth ==========\\

		//Change month into number (still concidered a String)

		month = month.replace("JANUARY","0");
		month = month.replace("FEBRUARY","1");
		month = month.replace("MARCH","2");
		month = month.replace("APRIL","3");
		month = month.replace("MAY","4");
		month = month.replace("JUNE","5");
		month = month.replace("JULY","6");
		month = month.replace("AUGUST","7");
		month = month.replace("SEPTEMBER","8");
		month = month.replace("OCTOBER","9");
		month = month.replace("NOVEMBER","10");
		month = month.replace("DECEMBER","11");

		//Change month into int

		int realMonth = Integer.parseInt( month );

		//create the calendar object

		GregorianCalendar birthDay = new GregorianCalendar();

		//set the calendar with the previously assigned variables

		birthDay.set(year, realMonth, day);

		//Get the weekday as a number 0-6

		int weekday = birthDay.get(GregorianCalendar.DAY_OF_WEEK);

		//convert GregorianCalendar.DAY_OF_WEEK into words

		String weekDay = String.valueOf(weekday -1);

		weekDay = weekDay.replace("0","Sunday.");
		weekDay = weekDay.replace("1","Monday.");
		weekDay = weekDay.replace("2","Tuesday.");
		weekDay = weekDay.replace("3","Wednesday.");
		weekDay = weekDay.replace("4","Thursday.");
		weekDay = weekDay.replace("5","Friday.");
		weekDay = weekDay.replace("6","Saturday."); 

		//print the weekday of birth

		System.out.println("You were born on a " +(weekDay)); 
	}
} 