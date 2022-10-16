–
C:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Application\InventoryManager.Application.DTOs\InventoryManager.Application.DTOs\DTO.cs
	namespace 	
InventoryManager
 
. 
Application &
.& '
DTOs' +
{ 
[ 
DataContract 
] 
public		 

abstract		 
class		 
DTO		 
{

 
[ 	

DataMember	 
] 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
} 
} ó
C:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Application\InventoryManager.Application.DTOs\InventoryManager.Application.DTOs\InventoryItemDTO.cs
	namespace 	
InventoryManager
 
. 
Application &
.& '
DTOs' +
{ 
[ 
DataContract 
] 
public		 

class		 
InventoryItemDTO		 !
:		" #
DTO		$ '
{

 
[ 	

DataMember	 
] 
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
[ 	

DataMember	 
] 
public 
DateTime 
? 
ExpirationDate '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
[ 	

DataMember	 
] 
public 
int 
Type 
{ 
get 
; 
set "
;" #
}$ %
} 
} Ž
¦C:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Application\InventoryManager.Application.DTOs\InventoryManager.Application.DTOs\InventoryItemDTOValidator.cs
	namespace 	
InventoryManager
 
. 
Application &
.& '
DTOs' +
{ 
public 

class %
InventoryItemDTOValidator *
:+ ,
AbstractValidator- >
<> ?
InventoryItemDTO? O
>O P
{		 
public %
InventoryItemDTOValidator (
(( )
)) *
{ 	
RuleFor 
( 
x 
=> 
x 
. 
Id 
) 
. 
NotNull &
(& '
)' (
.( ) 
GreaterThanOrEqualTo) =
(= >
$num> ?
)? @
;@ A
RuleFor 
( 
x 
=> 
x 
. 
Name 
)  
.  !
Length! '
(' (
$num( )
,) *
$num+ -
)- .
.. /
NotNull/ 6
(6 7
)7 8
;8 9
RuleFor 
( 
x 
=> 
x 
. 
ExpirationDate )
)) *
.* +
GreaterThan+ 6
(6 7
new7 :
DateTime; C
(C D
$numD H
,H I
$numJ K
,K L
$numM N
)N O
)O P
;P Q
RuleFor 
( 
x 
=> 
x 
. 
Type 
)  
.  !
InclusiveBetween! 1
(1 2
$num2 3
,3 4
$num5 7
)7 8
;8 9
} 	
} 
} 