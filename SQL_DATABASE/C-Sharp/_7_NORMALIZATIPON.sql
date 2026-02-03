/*
id = 1 Name = SANDEEP 
COURSE = JAVA ,PYTHON 
STATE = UP 
COUNTRY = INDIA 
PURCHASED ITEMS = MOBILE,WATCH,SHOES 
PURCHASED QUANTITY = 1,1,2 
UNIT PRICE = 10000,800,1200

======================TABLE IN NORMALIZED FORM======================

------------------------Student----------------------------			
student_id		name		  state_id
1				SANDEEP			3			   
	
SELECT        
FROM            
------------------------State  Master------------------------
state_id		state_name
1				Bihar
2				Punjab
3				UP
4				Tamil
5				WB

			
------------------------Course-----------------------------			
course_id	course_name		
1				JAVA		
2				PYTHON		
			
			
---------------------Student_Course-------------------------			
student_id	course_id		
1				1		
1				2		
			
			
---------------------------Item------------------------------			
item_id		item_name	unit_price	
1			MOBILE		10000	
2			WATCH		800	
3			SHOES		1200	
			
			
------------------------Purchase-------------------------------			
purchase_id		student_id		item_id		quantity
1				1				1			1
2				1				2			1
3				1				3			2
*/


/*

id =1 
Name = SANDEEP 
DEPOSITES = Multiple with date 
    1/1/2026 - 5000 
    7/1/2026 - 8000 
    16/1/2026 - 11000     
WIDTHDRAW multiple with date 
    11/1/2026 5000 
    19/1/2026 2000 
PAN card 
Total Balance 
Father Name 
Address



------------------Customer------------------------				
customer_id	name	father_name	pan_card	address
1	SANDEEP	Ram Bilash	123456789	UP
				
				
------------------Account-------------------------				
account_id	customer_id	total_balance		
1	1	17000		
				
				
------------------Deposit						
deposit_id	account_id	deposit_date	amount	
1	1	01-01-2026	5000	
2	1	07-01-2026	8000	
3	1	16-01-2026	11000	
				
				
------------------Withdraw						
withdraw_id	account_id	withdraw_date	amount	
1	1	11-01-2026	5000	
2	1	19-01-2026	2000	
*/
