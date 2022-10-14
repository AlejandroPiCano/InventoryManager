’
êC:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Application\InventoryManager.Application\Application.Services\IInventoryListService.cs
	namespace 	
InventoryManager
 
. 
Application &
.& '
Services' /
{ 
public 

	interface !
IInventoryListService *
{ 
InventoryItemDTO ,
 GetBussinessInventoryItemExample 9
(9 :
): ;
;; <
ValidationResultDTO 
Create "
(" #
InventoryItemDTO# 3
inventoryItemDTO4 D
)D E
;E F
ValidationResultDTO 
Update "
(" #
int# &
id' )
,) *
InventoryItemDTO+ ;
inventoryItemDTO< L
)L M
;M N
ValidationResultDTO 
Delete "
(" #
int# &
id' )
)) *
;* +
ValidationResultDTO$$ 
DeleteByName$$ (
($$( )
string$$) /
name$$0 4
)$$4 5
;$$5 6
InventoryItemDTO++ 
GetInventoryItem++ )
(++) *
int++* -
id++. 0
)++0 1
;++1 2
List11 
<11 
InventoryItemDTO11 
>11  
GetAllInventoryItems11 3
(113 4
)114 5
;115 6
Task77 
<77 
ValidationResultDTO77  
>77  !
CreateAsync77" -
(77- .
InventoryItemDTO77. >
inventoryItemDTO77? O
)77O P
;77P Q
Task>> 
<>> 
ValidationResultDTO>>  
>>>  !
UpdateAsync>>" -
(>>- .
int>>. 1
id>>2 4
,>>4 5
InventoryItemDTO>>6 F
inventoryItemDTO>>G W
)>>W X
;>>X Y
TaskDD 
<DD 
ValidationResultDTODD  
>DD  !
DeleteAsyncDD" -
(DD- .
intDD. 1
idDD2 4
)DD4 5
;DD5 6
TaskKK 
<KK 
InventoryItemDTOKK 
>KK !
GetInventoryItemAsyncKK 4
(KK4 5
intKK5 8
idKK9 ;
)KK; <
;KK< =
TaskQQ 
<QQ 
ListQQ 
<QQ 
InventoryItemDTOQQ "
>QQ" #
>QQ# $%
GetAllInventoryItemsAsyncQQ% >
(QQ> ?
)QQ? @
;QQ@ A
}RR 
}SS ÄV
èC:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Application\InventoryManager.Application\Application.Services\InventoryListService.cs
	namespace 	
InventoryManager
 
. 
Application &
.& '
Services' /
{ 
public 

class  
InventoryListService %
:& '!
IInventoryListService( =
{		 
readonly

 #
IInventoryDomainService

 (&
inventoryListDomainService

) C
;

C D
readonly 
IRepository 
< 
InventoryItem *
>* +#
inventoryListRepository, C
;C D
public  
InventoryListService #
(# $#
IInventoryDomainService$ ;&
inventoryListDomainService< V
,V W
IRepositoryX c
<c d
InventoryItemd q
>q r$
inventoryListRepository	s ä
)
ä ã
{ 	
this 
. &
inventoryListDomainService +
=, -&
inventoryListDomainService. H
;H I
this 
. #
inventoryListRepository (
=) *#
inventoryListRepository+ B
;B C
} 	
InventoryItemDTO !
IInventoryListService .
.. /,
 GetBussinessInventoryItemExample/ O
(O P
)P Q
{ 	
return "
InventoryItemConverter )
.) *+
ConvertInventoryItemEntityToDTO* I
(I J&
inventoryListDomainServiceJ d
.d e-
 GetBussinessInventoryItemExample	e Ö
(
Ö Ü
)
Ü á
)
á à
;
à â
} 	
ValidationResultDTO!! !
IInventoryListService!! 1
.!!1 2
Create!!2 8
(!!8 9
InventoryItemDTO!!9 I
inventoryItemDTO!!J Z
)!!Z [
{"" 	
var## 
result## 
=## 
inventoryItemDTO## )
.##) *
CheckValidation##* 9
(##9 :
)##: ;
;##; <
if%% 
(%% 
result%% 
.%% 
Result%% 
==%%  
ResultTypeDTO%%! .
.%%. /
Ok%%/ 1
)%%1 2
{&& 
this'' 
.'' #
inventoryListRepository'' ,
.'', -
Create''- 3
(''3 4"
InventoryItemConverter''4 J
.''J K(
ConvertInventoryDTOToEntitiy''K g
(''g h
inventoryItemDTO''h x
,''x y$
inventoryListRepository	''z ë
.
''ë í
GetNew
''í ò
(
''ò ô
)
''ô ö
,
''ö õ
true
''ú †
)
''† °
)
''° ¢
;
''¢ £
}(( 
return** 
result** 
;** 
}++ 	
ValidationResultDTO11 !
IInventoryListService11 1
.111 2
Delete112 8
(118 9
int119 <
id11= ?
)11? @
{22 	
this33 
.33 #
inventoryListRepository33 (
.33( )
Delete33) /
(33/ 0
id330 2
)332 3
;333 4
return55 
new55 
ValidationResultDTO55 *
(55* +
)55+ ,
;55, -
}66 	
List<< 
<<< 
InventoryItemDTO<< 
><< !
IInventoryListService<< 4
.<<4 5 
GetAllInventoryItems<<5 I
(<<I J
)<<J K
{== 	
return>> 
this>> 
.>> #
inventoryListRepository>> /
.>>/ 0
GetAll>>0 6
(>>6 7
)>>7 8
.>>8 9
Select>>9 ?
(>>? @
i>>@ A
=>>>B D"
InventoryItemConverter>>E [
.>>[ \+
ConvertInventoryItemEntityToDTO>>\ {
(>>{ |
i>>| }
)>>} ~
)>>~ 
.	>> Ä
ToList
>>Ä Ü
(
>>Ü á
)
>>á à
;
>>à â
}?? 	
InventoryItemDTOFF !
IInventoryListServiceFF .
.FF. /
GetInventoryItemFF/ ?
(FF? @
intFF@ C
idFFD F
)FFF G
{GG 	
varHH 
inventoryItemHH 
=HH 
thisHH  $
.HH$ %#
inventoryListRepositoryHH% <
.HH< =
GetHH= @
(HH@ A
idHHA C
)HHC D
;HHD E
returnJJ "
InventoryItemConverterJJ )
.JJ) *+
ConvertInventoryItemEntityToDTOJJ* I
(JJI J
inventoryItemJJJ W
)JJW X
;JJX Y
}KK 	
ValidationResultDTORR !
IInventoryListServiceRR 1
.RR1 2
UpdateRR2 8
(RR8 9
intRR9 <
idRR= ?
,RR? @
InventoryItemDTORRA Q
inventoryItemDTORRR b
)RRb c
{SS 	
varTT 
resultTT 
=TT 
inventoryItemDTOTT )
.TT) *
CheckValidationTT* 9
(TT9 :
)TT: ;
;TT; <
ifVV 
(VV 
resultVV 
.VV 
ResultVV 
==VV  
ResultTypeDTOVV! .
.VV. /
OkVV/ 1
)VV1 2
{WW 
thisXX 
.XX #
inventoryListRepositoryXX ,
.XX, -
UpdateXX- 3
(XX3 4
idXX4 6
,XX6 7"
InventoryItemConverterXX8 N
.XXN O(
ConvertInventoryDTOToEntitiyXXO k
(XXk l
inventoryItemDTOXXl |
,XX| }$
inventoryListRepository	XX~ ï
.
XXï ñ
GetNew
XXñ ú
(
XXú ù
)
XXù û
)
XXû ü
)
XXü †
;
XX† °
}YY 
return[[ 
result[[ 
;[[ 
}\\ 	
public^^ 
async^^ 
Task^^ 
<^^ 
List^^ 
<^^ 
InventoryItemDTO^^ /
>^^/ 0
>^^0 1%
GetAllInventoryItemsAsync^^2 K
(^^K L
)^^L M
{__ 	
var`` 
result`` 
=`` 
await`` 
this`` #
.``# $#
inventoryListRepository``$ ;
.``; <
GetAllAsync``< G
(``G H
)``H I
;``I J
returnbb 
resultbb 
.bb 
Selectbb  
(bb  !
ibb! "
=>bb# %"
InventoryItemConverterbb& <
.bb< =+
ConvertInventoryItemEntityToDTObb= \
(bb\ ]
ibb] ^
)bb^ _
)bb_ `
.bb` a
ToListbba g
(bbg h
)bbh i
;bbi j
}cc 	
publicee 
asyncee 
Taskee 
<ee 
ValidationResultDTOee -
>ee- .
CreateAsyncee/ :
(ee: ;
InventoryItemDTOee; K
inventoryItemDTOeeL \
)ee\ ]
{ff 	
vargg 
resultgg 
=gg 
inventoryItemDTOgg )
.gg) *
CheckValidationgg* 9
(gg9 :
)gg: ;
;gg; <
ifii 
(ii 
resultii 
.ii 
Resultii 
==ii  
ResultTypeDTOii! .
.ii. /
Okii/ 1
)ii1 2
{jj 
awaitkk 
thiskk 
.kk #
inventoryListRepositorykk 2
.kk2 3
CreateAsynckk3 >
(kk> ?"
InventoryItemConverterkk? U
.kkU V(
ConvertInventoryDTOToEntitiykkV r
(kkr s
inventoryItemDTO	kks É
,
kkÉ Ñ%
inventoryListRepository
kkÖ ú
.
kkú ù
GetNew
kkù £
(
kk£ §
)
kk§ •
,
kk• ¶
true
kkß ´
)
kk´ ¨
)
kk¨ ≠
;
kk≠ Æ
}ll 
returnnn 
resultnn 
;nn 
}oo 	
publicqq 
asyncqq 
Taskqq 
<qq 
ValidationResultDTOqq -
>qq- .
UpdateAsyncqq/ :
(qq: ;
intqq; >
idqq? A
,qqA B
InventoryItemDTOqqC S
inventoryItemDTOqqT d
)qqd e
{rr 	
varss 
resultss 
=ss 
inventoryItemDTOss )
.ss) *
CheckValidationss* 9
(ss9 :
)ss: ;
;ss; <
ifuu 
(uu 
resultuu 
.uu 
Resultuu 
==uu  
ResultTypeDTOuu! .
.uu. /
Okuu/ 1
)uu1 2
{vv 
awaitww 
thisww 
.ww #
inventoryListRepositoryww 2
.ww2 3
UpdateAsyncww3 >
(ww> ?
idww? A
,wwA B"
InventoryItemConverterwwC Y
.wwY Z(
ConvertInventoryDTOToEntitiywwZ v
(wwv w
inventoryItemDTO	www á
,
wwá à%
inventoryListRepository
wwâ †
.
ww† °
GetNew
ww° ß
(
wwß ®
)
ww® ©
)
ww© ™
)
ww™ ´
;
ww´ ¨
}xx 
returnzz 
resultzz 
;zz 
}{{ 	
public}} 
async}} 
Task}} 
<}} 
ValidationResultDTO}} -
>}}- .
DeleteAsync}}/ :
(}}: ;
int}}; >
id}}? A
)}}A B
{~~ 	
await 
this 
. #
inventoryListRepository .
.. /
DeleteAsync/ :
(: ;
id; =
)= >
;> ?
return
ÅÅ 
new
ÅÅ !
ValidationResultDTO
ÅÅ *
(
ÅÅ* +
)
ÅÅ+ ,
;
ÅÅ, -
}
ÇÇ 	
public
ÑÑ 
async
ÑÑ 
Task
ÑÑ 
<
ÑÑ 
InventoryItemDTO
ÑÑ *
>
ÑÑ* +#
GetInventoryItemAsync
ÑÑ, A
(
ÑÑA B
int
ÑÑB E
id
ÑÑF H
)
ÑÑH I
{
ÖÖ 	
var
ÜÜ 
inventoryItem
ÜÜ 
=
ÜÜ 
await
ÜÜ  %
this
ÜÜ& *
.
ÜÜ* +%
inventoryListRepository
ÜÜ+ B
.
ÜÜB C
GetAsync
ÜÜC K
(
ÜÜK L
id
ÜÜL N
)
ÜÜN O
;
ÜÜO P
return
àà $
InventoryItemConverter
àà )
.
àà) *-
ConvertInventoryItemEntityToDTO
àà* I
(
ààI J
inventoryItem
ààJ W
)
ààW X
;
ààX Y
}
ââ 	
public
ãã !
ValidationResultDTO
ãã "
DeleteByName
ãã# /
(
ãã/ 0
string
ãã0 6
name
ãã7 ;
)
ãã; <
{
åå 	
this
çç 
.
çç %
inventoryListRepository
çç (
.
çç( )
DeleteByName
çç) 5
(
çç5 6
name
çç6 :
)
çç: ;
;
çç; <
return
èè 
new
èè !
ValidationResultDTO
èè *
(
èè* +
)
èè+ ,
;
èè, -
}
êê 	
}
íí 
}ìì «
|C:\Users\Ale\Desktop\MichaelPage\Backend\InventoryManager\Application\InventoryManager.Application\InventoryItemConverter.cs
	namespace 	
InventoryManager
 
. 
Application &
{ 
internal 
static 
class "
InventoryItemConverter 0
{ 
internal 
static 
InventoryItemDTO (+
ConvertInventoryItemEntityToDTO) H
(H I
InventoryItemI V
inventoryItemW d
)d e
{ 	
if 
( 
inventoryItem 
==  
null! %
)% &
return 
null 
; 
return 
new 
InventoryItemDTO '
(' (
)( )
{ 
Id 
= 
inventoryItem "
." #
Id# %
,% &
Name 
= 
inventoryItem $
.$ %
Name% )
,) *
ExpirationDate 
=  
inventoryItem! .
.. /
ExpirationDate/ =
,= >
Type 
= 
inventoryItem $
.$ %
Type% )
} 
; 
} 	
internal   
static   
InventoryItem   %(
ConvertInventoryDTOToEntitiy  & B
(  B C
InventoryItemDTO  C S
inventoryItemDTO  T d
,  d e
InventoryItem  f s
instance  t |
,  | }
bool	  ~ Ç

isCreation
  É ç
=
  é è
false
  ê ï
)
  ï ñ
{!! 	
if"" 
("" 
inventoryItemDTO""  
==""! #
null""$ (
)""( )
return## 
null## 
;## 
instance%% 
.%% 
Id%% 
=%% 

isCreation%% $
?%%% &
$num%%' (
:%%) *
inventoryItemDTO%%+ ;
.%%; <
Id%%< >
;%%> ?
instance&& 
.&& 
Name&& 
=&& 
inventoryItemDTO&& ,
.&&, -
Name&&- 1
;&&1 2
instance'' 
.'' 
ExpirationDate'' #
=''$ %
inventoryItemDTO''& 6
.''6 7
ExpirationDate''7 E
;''E F
instance(( 
.(( 
Type(( 
=(( 
inventoryItemDTO(( ,
.((, -
Type((- 1
;((1 2
return** 
instance** 
;** 
}++ 	
},, 
}-- 