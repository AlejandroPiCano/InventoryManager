�
�C:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Application\InventoryManager.Application\Application.Services\IInventoryListService.cs
	namespace 	
InventoryManager
 
. 
Application &
.& '
Services' /
{ 
public 

	interface !
IInventoryListService *
{ 
InventoryItemDTO ,
 GetBussinessInventoryItemExample 9
(9 :
): ;
;; <
ValidationResult 
Create 
(  
InventoryItemDTO  0
inventoryItemDTO1 A
)A B
;B C
ValidationResult 
Update 
(  
int  #
id$ &
,& '
InventoryItemDTO( 8
inventoryItemDTO9 I
)I J
;J K
ValidationResult 
Delete 
(  
int  #
id$ &
)& '
;' (
ValidationResult%% 
DeleteByName%% %
(%%% &
string%%& ,
name%%- 1
)%%1 2
;%%2 3
InventoryItemDTO,, 
GetInventoryItem,, )
(,,) *
int,,* -
id,,. 0
),,0 1
;,,1 2
List22 
<22 
InventoryItemDTO22 
>22  
GetAllInventoryItems22 3
(223 4
)224 5
;225 6
Task88 
<88 
ValidationResult88 
>88 
CreateAsync88 *
(88* +
InventoryItemDTO88+ ;
inventoryItemDTO88< L
)88L M
;88M N
Task?? 
<?? 
ValidationResult?? 
>?? 
UpdateAsync?? *
(??* +
int??+ .
id??/ 1
,??1 2
InventoryItemDTO??3 C
inventoryItemDTO??D T
)??T U
;??U V
TaskEE 
<EE 
ValidationResultEE 
>EE 
DeleteAsyncEE *
(EE* +
intEE+ .
idEE/ 1
)EE1 2
;EE2 3
TaskLL 
<LL 
InventoryItemDTOLL 
>LL !
GetInventoryItemAsyncLL 4
(LL4 5
intLL5 8
idLL9 ;
)LL; <
;LL< =
TaskRR 
<RR 
ListRR 
<RR 
InventoryItemDTORR "
>RR" #
>RR# $%
GetAllInventoryItemsAsyncRR% >
(RR> ?
)RR? @
;RR@ A
}SS 
}TT �X
�C:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Application\InventoryManager.Application\Application.Services\InventoryListService.cs
	namespace 	
InventoryManager
 
. 
Application &
.& '
Services' /
{		 
public 

class  
InventoryListService %
:& '!
IInventoryListService( =
{ 
readonly #
IInventoryDomainService (&
inventoryListDomainService) C
;C D
readonly 
IRepository 
< 
InventoryItem *
>* +#
inventoryListRepository, C
;C D
readonly 

IValidator 
< 
InventoryItemDTO ,
>, -
	validator. 7
;7 8
public  
InventoryListService #
(# $#
IInventoryDomainService$ ;&
inventoryListDomainService< V
,V W
IRepositoryX c
<c d
InventoryItemd q
>q r$
inventoryListRepository	s �
,
� �

IValidator
� �
<
� �
InventoryItemDTO
� �
>
� �
	validator
� �
)
� �
{ 	
this 
. &
inventoryListDomainService +
=, -&
inventoryListDomainService. H
;H I
this 
. #
inventoryListRepository (
=) *#
inventoryListRepository+ B
;B C
this 
. 
	validator 
= 
	validator &
;& '
} 	
InventoryItemDTO&& !
IInventoryListService&& .
.&&. /,
 GetBussinessInventoryItemExample&&/ O
(&&O P
)&&P Q
{'' 	
return(( "
InventoryItemConverter(( )
.(() *+
ConvertInventoryItemEntityToDTO((* I
(((I J&
inventoryListDomainService((J d
.((d e-
 GetBussinessInventoryItemExample	((e �
(
((� �
)
((� �
)
((� �
;
((� �
})) 	
ValidationResult.. !
IInventoryListService.. .
.... /
Create../ 5
(..5 6
InventoryItemDTO..6 F
inventoryItemDTO..G W
)..W X
{// 	
ValidationResult00 
result00 #
=00$ %
	validator00& /
.00/ 0
Validate000 8
(008 9
inventoryItemDTO009 I
)00I J
;00J K
if22 
(22 
result22 
.22 
IsValid22 
)22 
{33 
this44 
.44 #
inventoryListRepository44 ,
.44, -
Create44- 3
(443 4"
InventoryItemConverter444 J
.44J K(
ConvertInventoryDTOToEntitiy44K g
(44g h
inventoryItemDTO44h x
,44x y$
inventoryListRepository	44z �
.
44� �
GetNew
44� �
(
44� �
)
44� �
,
44� �
true
44� �
)
44� �
)
44� �
;
44� �
}55 
return77 
result77 
;77 
}88 	
ValidationResult>> !
IInventoryListService>> .
.>>. /
Delete>>/ 5
(>>5 6
int>>6 9
id>>: <
)>>< =
{?? 	
this@@ 
.@@ #
inventoryListRepository@@ (
.@@( )
Delete@@) /
(@@/ 0
id@@0 2
)@@2 3
;@@3 4
returnBB 
newBB 
ValidationResultBB '
(BB' (
)BB( )
;BB) *
}CC 	
ListII 
<II 
InventoryItemDTOII 
>II !
IInventoryListServiceII 4
.II4 5 
GetAllInventoryItemsII5 I
(III J
)IIJ K
{JJ 	
returnKK 
thisKK 
.KK #
inventoryListRepositoryKK /
.KK/ 0
GetAllKK0 6
(KK6 7
)KK7 8
.KK8 9
SelectKK9 ?
(KK? @
iKK@ A
=>KKB D"
InventoryItemConverterKKE [
.KK[ \+
ConvertInventoryItemEntityToDTOKK\ {
(KK{ |
iKK| }
)KK} ~
)KK~ 
.	KK �
ToList
KK� �
(
KK� �
)
KK� �
;
KK� �
}LL 	
InventoryItemDTOSS !
IInventoryListServiceSS .
.SS. /
GetInventoryItemSS/ ?
(SS? @
intSS@ C
idSSD F
)SSF G
{TT 	
varUU 
inventoryItemUU 
=UU 
thisUU  $
.UU$ %#
inventoryListRepositoryUU% <
.UU< =
GetUU= @
(UU@ A
idUUA C
)UUC D
;UUD E
returnWW "
InventoryItemConverterWW )
.WW) *+
ConvertInventoryItemEntityToDTOWW* I
(WWI J
inventoryItemWWJ W
)WWW X
;WWX Y
}XX 	
ValidationResult__ !
IInventoryListService__ .
.__. /
Update__/ 5
(__5 6
int__6 9
id__: <
,__< =
InventoryItemDTO__> N
inventoryItemDTO__O _
)___ `
{`` 	
ValidationResultaa 
resultaa #
=aa$ %
	validatoraa& /
.aa/ 0
Validateaa0 8
(aa8 9
inventoryItemDTOaa9 I
)aaI J
;aaJ K
ifcc 
(cc 
resultcc 
.cc 
IsValidcc 
)cc 
{dd 
thisee 
.ee #
inventoryListRepositoryee ,
.ee, -
Updateee- 3
(ee3 4
idee4 6
,ee6 7"
InventoryItemConverteree8 N
.eeN O(
ConvertInventoryDTOToEntitiyeeO k
(eek l
inventoryItemDTOeel |
,ee| }$
inventoryListRepository	ee~ �
.
ee� �
GetNew
ee� �
(
ee� �
)
ee� �
)
ee� �
)
ee� �
;
ee� �
}ff 
returnhh 
resulthh 
;hh 
}ii 	
publickk 
asynckk 
Taskkk 
<kk 
Listkk 
<kk 
InventoryItemDTOkk /
>kk/ 0
>kk0 1%
GetAllInventoryItemsAsynckk2 K
(kkK L
)kkL M
{ll 	
varmm 
resultmm 
=mm 
awaitmm 
thismm #
.mm# $#
inventoryListRepositorymm$ ;
.mm; <
GetAllAsyncmm< G
(mmG H
)mmH I
;mmI J
returnoo 
resultoo 
.oo 
Selectoo  
(oo  !
ioo! "
=>oo# %"
InventoryItemConverteroo& <
.oo< =+
ConvertInventoryItemEntityToDTOoo= \
(oo\ ]
ioo] ^
)oo^ _
)oo_ `
.oo` a
ToListooa g
(oog h
)ooh i
;ooi j
}pp 	
publicrr 
asyncrr 
Taskrr 
<rr 
ValidationResultrr *
>rr* +
CreateAsyncrr, 7
(rr7 8
InventoryItemDTOrr8 H
inventoryItemDTOrrI Y
)rrY Z
{ss 	
ValidationResulttt 
resulttt #
=tt$ %
	validatortt& /
.tt/ 0
Validatett0 8
(tt8 9
inventoryItemDTOtt9 I
)ttI J
;ttJ K
ifvv 
(vv 
resultvv 
.vv 
IsValidvv 
)vv 
{ww 
awaitxx 
thisxx 
.xx #
inventoryListRepositoryxx 2
.xx2 3
CreateAsyncxx3 >
(xx> ?"
InventoryItemConverterxx? U
.xxU V(
ConvertInventoryDTOToEntitiyxxV r
(xxr s
inventoryItemDTO	xxs �
,
xx� �%
inventoryListRepository
xx� �
.
xx� �
GetNew
xx� �
(
xx� �
)
xx� �
,
xx� �
true
xx� �
)
xx� �
)
xx� �
;
xx� �
}yy 
return{{ 
result{{ 
;{{ 
}|| 	
public~~ 
async~~ 
Task~~ 
<~~ 
ValidationResult~~ *
>~~* +
UpdateAsync~~, 7
(~~7 8
int~~8 ;
id~~< >
,~~> ?
InventoryItemDTO~~@ P
inventoryItemDTO~~Q a
)~~a b
{ 	
ValidationResult
�� 
result
�� #
=
��$ %
	validator
��& /
.
��/ 0
Validate
��0 8
(
��8 9
inventoryItemDTO
��9 I
)
��I J
;
��J K
if
�� 
(
�� 
result
�� 
.
�� 
IsValid
�� 
)
�� 
{
�� 
await
�� 
this
�� 
.
�� %
inventoryListRepository
�� 2
.
��2 3
UpdateAsync
��3 >
(
��> ?
id
��? A
,
��A B$
InventoryItemConverter
��C Y
.
��Y Z*
ConvertInventoryDTOToEntitiy
��Z v
(
��v w
inventoryItemDTO��w �
,��� �'
inventoryListRepository��� �
.��� �
GetNew��� �
(��� �
)��� �
)��� �
)��� �
;��� �
}
�� 
return
�� 
result
�� 
;
�� 
}
�� 	
public
�� 
async
�� 
Task
�� 
<
�� 
ValidationResult
�� *
>
��* +
DeleteAsync
��, 7
(
��7 8
int
��8 ;
id
��< >
)
��> ?
{
�� 	
await
�� 
this
�� 
.
�� %
inventoryListRepository
�� .
.
��. /
DeleteAsync
��/ :
(
��: ;
id
��; =
)
��= >
;
��> ?
return
�� 
new
�� 
ValidationResult
�� '
(
��' (
)
��( )
;
��) *
}
�� 	
public
�� 
async
�� 
Task
�� 
<
�� 
InventoryItemDTO
�� *
>
��* +#
GetInventoryItemAsync
��, A
(
��A B
int
��B E
id
��F H
)
��H I
{
�� 	
var
�� 
inventoryItem
�� 
=
�� 
await
��  %
this
��& *
.
��* +%
inventoryListRepository
��+ B
.
��B C
GetAsync
��C K
(
��K L
id
��L N
)
��N O
;
��O P
return
�� $
InventoryItemConverter
�� )
.
��) *-
ConvertInventoryItemEntityToDTO
��* I
(
��I J
inventoryItem
��J W
)
��W X
;
��X Y
}
�� 	
public
�� 
ValidationResult
�� 
DeleteByName
��  ,
(
��, -
string
��- 3
name
��4 8
)
��8 9
{
�� 	
this
�� 
.
�� %
inventoryListRepository
�� (
.
��( )
DeleteByName
��) 5
(
��5 6
name
��6 :
)
��: ;
;
��; <
return
�� 
new
�� 
ValidationResult
�� '
(
��' (
)
��( )
;
��) *
}
�� 	
}
�� 
}�� �
|C:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Application\InventoryManager.Application\InventoryItemConverter.cs
	namespace 	
InventoryManager
 
. 
Application &
{ 
internal		 
static		 
class		 "
InventoryItemConverter		 0
{

 
internal 
static 
InventoryItemDTO (+
ConvertInventoryItemEntityToDTO) H
(H I
InventoryItemI V
inventoryItemW d
)d e
{ 	
if 
( 
inventoryItem 
==  
null! %
)% &
return 
null 
; 
return 
new 
InventoryItemDTO '
(' (
)( )
{ 
Id 
= 
inventoryItem "
." #
Id# %
,% &
Name 
= 
inventoryItem $
.$ %
Name% )
,) *
ExpirationDate 
=  
inventoryItem! .
.. /
ExpirationDate/ =
,= >
Type 
= 
inventoryItem $
.$ %
Type% )
} 
; 
} 	
internal## 
static## 
InventoryItem## %(
ConvertInventoryDTOToEntitiy##& B
(##B C
InventoryItemDTO##C S
inventoryItemDTO##T d
,##d e
InventoryItem##f s
instance##t |
,##| }
bool	##~ �

isCreation
##� �
=
##� �
false
##� �
)
##� �
{$$ 	
if%% 
(%% 
inventoryItemDTO%%  
==%%! #
null%%$ (
)%%( )
return&& 
null&& 
;&& 
instance(( 
.(( 
Id(( 
=(( 

isCreation(( $
?((% &
$num((' (
:(() *
inventoryItemDTO((+ ;
.((; <
Id((< >
;((> ?
instance)) 
.)) 
Name)) 
=)) 
inventoryItemDTO)) ,
.)), -
Name))- 1
;))1 2
instance** 
.** 
ExpirationDate** #
=**$ %
inventoryItemDTO**& 6
.**6 7
ExpirationDate**7 E
;**E F
instance++ 
.++ 
Type++ 
=++ 
inventoryItemDTO++ ,
.++, -
Type++- 1
;++1 2
return-- 
instance-- 
;-- 
}.. 	
}// 
}00 