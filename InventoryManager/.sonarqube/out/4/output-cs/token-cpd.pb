¿
êC:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Application\InventoryManager.Application\Application.Services\IInventoryListService.cs
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
}TT ªX
èC:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Application\InventoryManager.Application\Application.Services\InventoryListService.cs
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
inventoryListRepository	s ä
,
ä ã

IValidator
å ñ
<
ñ ó
InventoryItemDTO
ó ß
>
ß ®
	validator
© ≤
)
≤ ≥
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
 GetBussinessInventoryItemExample	((e Ö
(
((Ö Ü
)
((Ü á
)
((á à
;
((à â
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
inventoryListRepository	44z ë
.
44ë í
GetNew
44í ò
(
44ò ô
)
44ô ö
,
44ö õ
true
44ú †
)
44† °
)
44° ¢
;
44¢ £
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
.	KK Ä
ToList
KKÄ Ü
(
KKÜ á
)
KKá à
;
KKà â
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
inventoryListRepository	ee~ ï
.
eeï ñ
GetNew
eeñ ú
(
eeú ù
)
eeù û
)
eeû ü
)
eeü †
;
ee† °
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
inventoryItemDTO	xxs É
,
xxÉ Ñ%
inventoryListRepository
xxÖ ú
.
xxú ù
GetNew
xxù £
(
xx£ §
)
xx§ •
,
xx• ¶
true
xxß ´
)
xx´ ¨
)
xx¨ ≠
;
xx≠ Æ
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
ÄÄ 
result
ÄÄ #
=
ÄÄ$ %
	validator
ÄÄ& /
.
ÄÄ/ 0
Validate
ÄÄ0 8
(
ÄÄ8 9
inventoryItemDTO
ÄÄ9 I
)
ÄÄI J
;
ÄÄJ K
if
ÇÇ 
(
ÇÇ 
result
ÇÇ 
.
ÇÇ 
IsValid
ÇÇ 
)
ÇÇ 
{
ÉÉ 
await
ÑÑ 
this
ÑÑ 
.
ÑÑ %
inventoryListRepository
ÑÑ 2
.
ÑÑ2 3
UpdateAsync
ÑÑ3 >
(
ÑÑ> ?
id
ÑÑ? A
,
ÑÑA B$
InventoryItemConverter
ÑÑC Y
.
ÑÑY Z*
ConvertInventoryDTOToEntitiy
ÑÑZ v
(
ÑÑv w
inventoryItemDTOÑÑw á
,ÑÑá à'
inventoryListRepositoryÑÑâ †
.ÑÑ† °
GetNewÑÑ° ß
(ÑÑß ®
)ÑÑ® ©
)ÑÑ© ™
)ÑÑ™ ´
;ÑÑ´ ¨
}
ÖÖ 
return
áá 
result
áá 
;
áá 
}
àà 	
public
ää 
async
ää 
Task
ää 
<
ää 
ValidationResult
ää *
>
ää* +
DeleteAsync
ää, 7
(
ää7 8
int
ää8 ;
id
ää< >
)
ää> ?
{
ãã 	
await
åå 
this
åå 
.
åå %
inventoryListRepository
åå .
.
åå. /
DeleteAsync
åå/ :
(
åå: ;
id
åå; =
)
åå= >
;
åå> ?
return
éé 
new
éé 
ValidationResult
éé '
(
éé' (
)
éé( )
;
éé) *
}
èè 	
public
ëë 
async
ëë 
Task
ëë 
<
ëë 
InventoryItemDTO
ëë *
>
ëë* +#
GetInventoryItemAsync
ëë, A
(
ëëA B
int
ëëB E
id
ëëF H
)
ëëH I
{
íí 	
var
ìì 
inventoryItem
ìì 
=
ìì 
await
ìì  %
this
ìì& *
.
ìì* +%
inventoryListRepository
ìì+ B
.
ììB C
GetAsync
ììC K
(
ììK L
id
ììL N
)
ììN O
;
ììO P
return
ïï $
InventoryItemConverter
ïï )
.
ïï) *-
ConvertInventoryItemEntityToDTO
ïï* I
(
ïïI J
inventoryItem
ïïJ W
)
ïïW X
;
ïïX Y
}
ññ 	
public
òò 
ValidationResult
òò 
DeleteByName
òò  ,
(
òò, -
string
òò- 3
name
òò4 8
)
òò8 9
{
ôô 	
this
öö 
.
öö %
inventoryListRepository
öö (
.
öö( )
DeleteByName
öö) 5
(
öö5 6
name
öö6 :
)
öö: ;
;
öö; <
return
úú 
new
úú 
ValidationResult
úú '
(
úú' (
)
úú( )
;
úú) *
}
ùù 	
}
üü 
}†† «
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
bool	##~ Ç

isCreation
##É ç
=
##é è
false
##ê ï
)
##ï ñ
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