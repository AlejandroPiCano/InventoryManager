ñ
êC:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Application\InventoryManager.Application.DTOs\InventoryManager.Application.DTOs\DTO.cs
	namespace 	
InventoryManager
 
. 
Application &
.& '
DTOs' +
{ 
public 

abstract 
class 
DTO 
{ 
public 
ValidationResultDTO "
CheckValidation# 2
(2 3
)3 4
{ 	
return		 
new		 
ValidationResultDTO		 *
(		* +
)		+ ,
;		, -
}

 	
} 
} ä
ùC:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Application\InventoryManager.Application.DTOs\InventoryManager.Application.DTOs\InventoryItemDTO.cs
	namespace 	
InventoryManager
 
. 
Application &
.& '
DTOs' +
{ 
[ 
DataContract 
] 
public 

class 
InventoryItemDTO !
:" #
DTO$ '
{ 
[ 	

DataMember	 
] 
public		 
int		 
Id		 
{		 
get		 
;		 
set		  
;		  !
}		" #
[ 	

DataMember	 
] 
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
[ 	

DataMember	 
] 
public 
DateTime 
? 
ExpirationDate '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
[ 	

DataMember	 
] 
public 
int 
Type 
{ 
get 
; 
set "
;" #
}$ %
public 
new 
ValidationResultDTO &
CheckValidation' 6
(6 7
)7 8
{ 	
ValidationResultDTO 
result  &
=' (
new) ,
ValidationResultDTO- @
(@ A
)A B
;B C
if 
( 
string 
. 
IsNullOrEmpty $
($ %
Name% )
)) *
)* +
{ 
result 
. 
Result 
= 
ResultTypeDTO  -
.- .
Error. 3
;3 4
result 
. 
Errors 
. 
Add !
(! "
string" (
.( )
Format) /
(/ 0
$str0 R
,R S
nameofT Z
(Z [
Name[ _
)_ `
)` a
)a b
;b c
} 
if 
( 
Id 
< 
$num 
) 
{ 
result   
.   
Result   
=   
ResultTypeDTO    -
.  - .
Error  . 3
;  3 4
result!! 
.!! 
Errors!! 
.!! 
Add!! !
(!!! "
string!!" (
.!!( )
Format!!) /
(!!/ 0
$str!!0 \
,!!\ ]
nameof!!^ d
(!!d e
Id!!e g
)!!g h
)!!h i
)!!i j
;!!j k
}"" 
return$$ 
result$$ 
;$$ 
}%% 	
}&& 
}'' Ã
öC:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Application\InventoryManager.Application.DTOs\InventoryManager.Application.DTOs\ResultTypeDTO.cs
	namespace 	
InventoryManager
 
. 
Application &
.& '
DTOs' +
{ 
public 

enum 
ResultTypeDTO 
{ 
Ok 

= 
$num 
, 
Warnings 
= 
$num 
, 
Error 
= 
$num 
} 
}		 –

†C:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Application\InventoryManager.Application.DTOs\InventoryManager.Application.DTOs\ValidationResultDTO.cs
	namespace 	
InventoryManager
 
. 
Application &
.& '
DTOs' +
{ 
[ 
DataContract 
] 
public 

class 
ValidationResultDTO $
:$ %
DTO& )
{ 
[		 	

DataMember			 
]		 
public

 
ResultTypeDTO

 
Result

 #
{

$ %
get

& )
;

) *
set

+ .
;

. /
}

0 1
[ 	

DataMember	 
] 
public 
List 
< 
string 
> 
Errors "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
ValidationResultDTO "
(" #
)# $
{ 	
Result 
= 
ResultTypeDTO "
." #
Ok# %
;% &
Errors 
= 
new 
List 
< 
string $
>$ %
(% &
)& '
;' (
} 	
} 
} 