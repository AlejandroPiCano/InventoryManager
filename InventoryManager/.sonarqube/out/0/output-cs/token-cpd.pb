º
œC:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Domain\InventoryManager.Domain.Entities\InventoryManager.Domain.Entities\BussinessInventoryItem.cs
	namespace 	
InventoryManager
 
. 
Domain !
.! "
Entities" *
{ 
public 

class "
BussinessInventoryItem '
:( )
InventoryItem* 7
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
DateTime 
? 
ExpirationDate '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
int 
Type 
{ 
get 
; 
set "
;" #
}$ %
} 
} ²
“C:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Domain\InventoryManager.Domain.Entities\InventoryManager.Domain.Entities\InventoryItem.cs
	namespace 	
InventoryManager
 
. 
Domain !
.! "
Entities" *
{ 
public 

	interface 
InventoryItem "
{ 
int 
Id 
{ 
get 
; 
set 
; 
} 
string 
Name 
{ 
get 
; 
set 
; 
}  !
DateTime 
? 
ExpirationDate  
{! "
get# &
;& '
set( +
;+ ,
}- .
int 
Type 
{ 
get 
; 
set 
; 
} 
} 
} 