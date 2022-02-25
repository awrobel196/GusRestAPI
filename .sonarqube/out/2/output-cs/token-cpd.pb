ä
LC:\Users\adam\source\repos\GusRestAPI\src\Application\DependencyInjection.cs
	namespace 	
Application
 
{ 
public 

static 
class 
DependencyInjection +
{ 
public 
static 
IServiceCollection (
AddApplication) 7
(7 8
this8 <
IServiceCollection= O
servicesP X
)X Y
{ 	
services 
. 
AddTransient !
<! "!
IAuthorizationService" 7
,7 8 
AuthorizationService9 M
>M N
(N O
)O P
;P Q
services 
. 
AddTransient !
<! "
ISetupBinding" /
,/ 0
SetupBinding1 =
>= >
(> ?
)? @
;@ A
services 
. 
AddTransient !
<! "!
IXmlResponseConverter" 7
,7 8 
XmlResponseConverter9 M
>M N
(N O
)O P
;P Q
services 
. 

AddMediatR 
(  
Assembly  (
.( ) 
GetExecutingAssembly) =
(= >
)> ?
)? @
;@ A
return 
services 
; 
} 	
} 
} “	
YC:\Users\adam\source\repos\GusRestAPI\src\Application\Extensions\OsobaPrawnaExtensions.cs
	namespace		 	
Application		
 
.		 

Extensions		  
{

 
public 

static 
class !
OsobaPrawnaExtensions -
{ 
public 
static 
bool 
	IsCorrect $
($ %
this% )
OsobaPrawna* 5
podmiot6 =
)= >
{ 	
if 
( 
String 
. 
IsNullOrEmpty $
($ %
podmiot% ,
., -
Nazwa- 2
)2 3
&& 
( 
String 
. 
IsNullOrEmpty (
(( )
podmiot) 0
.0 1
NIP1 4
)4 5
&& 
( 
String 
. 
IsNullOrEmpty ,
(, -
podmiot- 4
.4 5$
NumerWRejestrzeEwidencji5 M
)M N
)N O
)O P
)P Q
returnR X
falseY ^
;^ _
return 
true 
; 
} 	
} 
} ô	
QC:\Users\adam\source\repos\GusRestAPI\src\Application\Extensions\PkdExtensions.cs
	namespace		 	
Application		
 
.		 

Extensions		  
{

 
public 

static 
class 
PkdExtensions %
{ 
public 
static 
bool 
	IsCorrect $
($ %
this% )
List* .
<. /
Pkd/ 2
>2 3
podmiot4 ;
); <
{ 	
if 
( 
String 
. 
IsNullOrEmpty $
($ %
podmiot% ,
., -
First- 2
(2 3
)3 4
.4 5
Nazwa5 :
): ;
&& 
( 
String 
. 
IsNullOrEmpty (
(( )
podmiot) 0
.0 1
First1 6
(6 7
)7 8
.8 9
KodPKD9 ?
)? @
)@ A
)A B
returnC I
falseJ O
;O P
return 
true 
; 
} 	
} 
} π	
UC:\Users\adam\source\repos\GusRestAPI\src\Application\Extensions\PodmiotExtensions.cs
	namespace		 	
Application		
 
.		 

Extensions		  
{

 
public 

static 
class 
PodmiotExtensions )
{ 
public 
static 
bool 
	IsCorrect $
($ %
this% )
Podmiot* 1
podmiot2 9
)9 :
{ 	
if 
( 
String 
. 
IsNullOrEmpty $
($ %
podmiot% ,
., -
Nazwa- 2
)2 3
&& 
( 
String 
. 
IsNullOrEmpty (
(( )
podmiot) 0
.0 1
Regon1 6
)6 7
&& 
( 
String 
. 
IsNullOrEmpty ,
(, -
podmiot- 4
.4 5
	StatusNip5 >
)> ?
)? @
)@ A
)A B
returnC I
falseJ O
;O P
return 
true 
; 
} 	
} 
} Æ	
TC:\Users\adam\source\repos\GusRestAPI\src\Application\Extensions\StringExtensions.cs
	namespace 	
Application
 
. 

Extensions  
{ 
public		 

static		 
class		 
StringExtensions		 (
{

 
public 
static 
bool 
IsCorrectNip '
(' (
this( ,
string- 3
nip4 7
)7 8
{ 	
if 
( 
nip 
. 
Length 
!= 
$num  
)  !
return" (
false) .
;. /
return 
true 
; 
} 	
public 
static 
bool 
IsCorrectRegon )
() *
this* .
string/ 5
regon6 ;
); <
{ 	
if 
( 
regon 
. 
Length 
!= 
$num  !
)! "
return# )
false* /
;/ 0
return 
true 
; 
} 	
} 
} ∑	
WC:\Users\adam\source\repos\GusRestAPI\src\Application\Extensions\WspolnicyExtensions.cs
	namespace		 	
Application		
 
.		 

Extensions		  
{

 
public 

static 
class 
WspolnicyExtensions +
{ 
public 
static 
bool 
	IsCorrect $
($ %
this% )
List* .
<. /
	Wspolnicy/ 8
>8 9
podmiot: A
)A B
{ 	
if 
( 
String 
. 
IsNullOrEmpty $
($ %
podmiot% ,
., -
First- 2
(2 3
)3 4
.4 5
RegonSpolki5 @
)@ A
&& 
( 
String 
. 
IsNullOrEmpty (
(( )
podmiot) 0
.0 1
First1 6
(6 7
)7 8
.8 9
ImiePierwsze9 E
)E F
)F G
)G H
returnI O
falseP U
;U V
return 
true 
; 
} 	
} 
} ‹
aC:\Users\adam\source\repos\GusRestAPI\src\Application\OsobaPrawnas\Queries\GetOsobaPrawnaQuery.cs
	namespace 	
Application
 
. 
OsobaPrawnas "
." #
Queries# *
{ 
public 

class 
GetOsobaPrawnaQuery $
:% &
	BaseQuery' 0
,0 1
IRequest2 :
<: ;
OsobaPrawna; F
>F G
{ 
public 
override 
string 
? 
NazwaRaportu  ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
=; <
$str= L
;L M
} 
public 

class &
GetOsobaPrawnaQueryHandler +
:, -
IRequestHandler. =
<= >
GetOsobaPrawnaQuery> Q
,Q R
OsobaPrawnaS ^
>^ _
{ 
private 
readonly !
IXmlResponseConverter .
_responseConverter/ A
;A B
public &
GetOsobaPrawnaQueryHandler )
() *!
IXmlResponseConverter* ?
responseConverter@ Q
)Q R
{ 	
_responseConverter 
=  
responseConverter! 2
;2 3
} 	
public 
async 
Task 
< 
OsobaPrawna %
>% &
Handle' -
(- .
GetOsobaPrawnaQuery. A
requestB I
,I J
CancellationTokenK \
cancellationToken] n
)n o
{ 	
try 
{ 
var 
osobaPrawna 
=  !
(" #
await# (
request) 0
.0 1
GusServices1 <
.< ='
DanePobierzPelnyRaportAsync= X
(X Y
requestY `
.` a
Regona f
,f g
requestg n
.n o
NazwaRaportuo {
){ |
)| }
.   (
DanePobierzPelnyRaportResult   1
;  1 2
if"" 
("" 
String"" 
."" 
IsNullOrEmpty"" (
(""( )
osobaPrawna"") 4
)""4 5
)""5 6
return""7 =
new""> A
OsobaPrawna""B M
(""M N
)""N O
;""O P
return%% 
(%% 
await%% 
_responseConverter%% 0
.%%0 1
Convert%%1 8
<%%8 9
OsobaPrawna%%9 D
>%%D E
(%%E F
osobaPrawna%%F Q
)%%Q R
)%%R S
.%%S T
First%%T Y
(%%Y Z
)%%Z [
;%%[ \
}'' 
catch(( 
((( 
	Exception(( 
ex(( 
)((  
{)) 
Console** 
.** 
	WriteLine** !
(**! "
ex**" $
.**$ %
Message**% ,
)**, -
;**- .
}++ 
return-- 
new-- 
(-- 
)-- 
;-- 
}.. 	
}// 
}00 ø
QC:\Users\adam\source\repos\GusRestAPI\src\Application\Pkds\Queries\GetPkdQuery.cs
	namespace 	
Application
 
. 
Pkds 
. 
Queries "
{ 
public 

class 
GetPkdQuery 
: 
	BaseQuery (
,( )
IRequest* 2
<2 3
List3 7
<7 8
Pkd8 ;
>; <
>< =
{ 
public 
override 
string 
? 
NazwaRaportu  ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
=; <
$str= O
;O P
} 
public 

class 
GetPkdQueryHandler #
:$ %
IRequestHandler& 5
<5 6
GetPkdQuery6 A
,A B
ListC G
<G H
PkdH K
>K L
>L M
{ 
private 
readonly !
IXmlResponseConverter .
_responseConverter/ A
;A B
public 
GetPkdQueryHandler !
(! "!
IXmlResponseConverter" 7
responseConverter8 I
)I J
{ 	
_responseConverter 
=  
responseConverter! 2
;2 3
} 	
public 
async 
Task 
< 
List 
< 
Pkd "
>" #
># $
Handle% +
(+ ,
GetPkdQuery, 7
request8 ?
,? @
CancellationTokenA R
cancellationTokenS d
)d e
{ 	
try 
{ 
var 
pkdPodmiotu 
=  !
(" #
await# (
request) 0
.0 1
GusServices1 <
.< ='
DanePobierzPelnyRaportAsync= X
(X Y
requestY `
.` a
Regona f
,f g
requestg n
.n o
NazwaRaportuo {
){ |
)| }
.   (
DanePobierzPelnyRaportResult   1
;  1 2
if"" 
("" 
String"" 
."" 
IsNullOrEmpty"" (
(""( )
pkdPodmiotu"") 4
)""4 5
)""5 6
return""7 =
new""> A
List""B F
<""F G
Pkd""G J
>""J K
(""K L
)""L M
;""M N
var%% 
listPkdPodmiotu%% #
=%%$ %
await%%& +
_responseConverter%%, >
.%%> ?
Convert%%? F
<%%F G
Pkd%%G J
>%%J K
(%%K L
pkdPodmiotu%%L W
)%%W X
;%%X Y
return&& 
listPkdPodmiotu&& &
;&&& '
}(( 
catch)) 
()) 
	Exception)) 
ex)) 
)))  
{** 
Console++ 
.++ 
	WriteLine++ !
(++! "
ex++" $
.++$ %
Message++% ,
)++, -
;++- .
},, 
return.. 
new.. 
(.. 
).. 
;.. 
}// 	
}00 
}11 ª
YC:\Users\adam\source\repos\GusRestAPI\src\Application\Podmiots\Queries\GetPodmiotQuery.cs
	namespace 	
Application
 
. 
Podmiots 
. 
Queries &
{ 
public 

class 
GetPodmiotQuery  
:! "
	BaseQuery" +
,+ ,
IRequest- 5
<5 6
Podmiot6 =
>= >
{ 
} 
public 

class "
GetPodmiotQueryHandler '
:( )
IRequestHandler* 9
<9 :
GetPodmiotQuery: I
,I J
PodmiotK R
>R S
{ 
private 
readonly !
IXmlResponseConverter .
_responseConverter/ A
;A B
public "
GetPodmiotQueryHandler %
(% &!
IXmlResponseConverter& ;
responseConverter< M
)M N
{ 	
_responseConverter 
=  
responseConverter! 2
;2 3
} 	
public 
async 
Task 
< 
Podmiot !
>! "
Handle# )
() *
GetPodmiotQuery* 9
request: A
,A B
CancellationTokenC T
cancellationTokenU f
)f g
{ 	!
ParametryWyszukiwania!! !
	parametry!!" +
=!!, -
new!!. 1
(!!1 2
)!!2 3
{"" 
Nip## 
=## 
request## 
.## 
Nip## !
}$$ 
;$$ 
try&& 
{'' 
var(( 
danePodmiotu((  
=((! "
(((# $
await(($ )
request((* 1
.((1 2
GusServices((2 =
.((= >#
DaneSzukajPodmiotyAsync((> U
(((U V
	parametry((V _
)((_ `
)((` a
.)) $
DaneSzukajPodmiotyResult)) -
;))- .
if++ 
(++ 
String++ 
.++ 
IsNullOrEmpty++ (
(++( )
danePodmiotu++) 5
)++5 6
)++6 7
return++8 >
new++? B
Podmiot++C J
(++J K
)++K L
;++L M
return-- 
(-- 
await-- 
_responseConverter-- 0
.--0 1
Convert--1 8
<--8 9
Podmiot--9 @
>--@ A
(--A B
danePodmiotu--B N
)--N O
)--O P
.--P Q
First--Q V
(--V W
)--W X
;--X Y
}// 
catch00 
(00 
	Exception00 
ex00 
)00  
{11 
Console22 
.22 
	WriteLine22 !
(22! "
ex22" $
.22$ %
Message22% ,
)22, -
;22- .
}33 
return55 
new55 
(55 
)55 
;55 
}66 	
};; 
}<< ò
HC:\Users\adam\source\repos\GusRestAPI\src\Application\Query\BaseQuery.cs
	namespace 	
Application
 
. 
Query 
{		 
public

 

class

 
	BaseQuery

 
{ 
public 
string 
? 
Regon 
; 
public 
string 
? 
Nip 
; 
public #
UslugaBIRzewnPublClient &
GusServices' 2
=3 4
default5 <
!< =
;= >
public 
virtual 
string 
? 
NazwaRaportu +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
} 
} ˜
VC:\Users\adam\source\repos\GusRestAPI\src\Application\Services\AuthorizationService.cs
	namespace 	
Application
 
. 
Services 
{ 
public

 

class

  
AuthorizationService

 %
:

& '!
IAuthorizationService

( =
{ 
private 
string 

_sessionId !
;! "
public  
AuthorizationService #
(# $
)$ %
{ 	

_sessionId 
= 
String 
.  
Empty  %
;% &
} 	
public 
void 
LoginIfRequired $
($ %
string% +
apiKey, 2
,2 3#
UslugaBIRzewnPublClient4 K
gusServicesL W
)W X
{ 	
string 

statuSesji 
= 
gusServices  +
.+ ,
GetValue, 4
(4 5
$str5 B
)B C
;C D
if 
( 

statuSesji 
== 
$str !
)! "
Login# (
(( )
apiKey) /
,/ 0
gusServices1 <
)< =
;= >
} 	
public 
bool 
Login 
( 
string  
apiKey! '
,' (#
UslugaBIRzewnPublClient) @
gusServicesA L
)L M
{ 	

_sessionId 
= 
gusServices $
.$ %
Zaloguj% ,
(, -
apiKey- 3
)3 4
;4 5
if 
( 
String 
. 
IsNullOrEmpty $
($ %

_sessionId% /
)/ 0
)0 1
return2 8
false9 >
;> ?!
OperationContextScope   !
scope  " '
=  ( )
new  * -!
OperationContextScope  . C
(  C D
gusServices  D O
.  O P
InnerChannel  P \
)  \ ]
;  ] ^&
HttpRequestMessageProperty!! &
requestProperties!!' 8
=!!9 :
new!!; >&
HttpRequestMessageProperty!!? Y
(!!Y Z
)!!Z [
;!![ \
requestProperties"" 
."" 
Headers"" %
.""% &
Add""& )
("") *
$str""* /
,""/ 0

_sessionId""1 ;
)""; <
;""< =
OperationContext## 
.## 
Current## $
.##$ %%
OutgoingMessageProperties##% >
[##> ?&
HttpRequestMessageProperty##? Y
.##Y Z
Name##Z ^
]##^ _
=##` a
requestProperties##b s
;##s t
return$$ 
true$$ 
;$$ 
}%% 	
public'' 
void'' 
Logout'' 
('' #
UslugaBIRzewnPublClient'' 2
gusServices''3 >
)''> ?
{(( 	
gusServices)) 
.)) 
Wyloguj))  
())  !

_sessionId))! +
)))+ ,
;)), -
}** 	
}++ 
},, ç
bC:\Users\adam\source\repos\GusRestAPI\src\Application\Services\Interfaces\IAuthorizationService.cs
	namespace 	
Application
 
. 
Services 
. 

Interfaces )
{		 
public

 

	interface

 !
IAuthorizationService

 *
{ 
void 
LoginIfRequired 
( 
string #
apiKey$ *
,* +#
UslugaBIRzewnPublClient, C
gusServicesD O
)O P
;P Q
bool 
Login 
( 
string 
apiKey  
,  !#
UslugaBIRzewnPublClient" 9
gusServices: E
)E F
;F G
void 
Logout 
( #
UslugaBIRzewnPublClient +
gusServices, 7
)7 8
;8 9
} 
} ’
ZC:\Users\adam\source\repos\GusRestAPI\src\Application\Services\Interfaces\ISetupBinding.cs
	namespace 	
Application
 
. 
Services 
. 

Interfaces )
;) *
public 
	interface 
ISetupBinding 
{ 
void 
Binding	 
( #
UslugaBIRzewnPublClient (
gusServices) 4
)4 5
;5 6
} Ò
bC:\Users\adam\source\repos\GusRestAPI\src\Application\Services\Interfaces\IXmlResponseConverter.cs
	namespace 	
Application
 
. 
Services 
. 

Interfaces )
{ 
public		 

	interface		 !
IXmlResponseConverter		 *
{

 
Task 
< 
List 
< 
T 
> 
> 
Convert 
< 
T 
>  
(  !
string! '
xmlResponse( 3
)3 4
where5 :
T; <
:= >
class? D
,D E
newF I
(I J
)J K
;K L
} 
} ∆

NC:\Users\adam\source\repos\GusRestAPI\src\Application\Services\SetupBinding.cs
	namespace

 	
Application


 
.

 
Services

 
{ 
public 

class 
SetupBinding 
: 
ISetupBinding  -
{ 
public 
void 
Binding 
( #
UslugaBIRzewnPublClient 3
gusServices4 ?
)? @
{ 	
var 
enc 
= 
new -
!MtomMessageEncodingBindingElement ;
(; <
)< =
;= >
var 
encoding 
= 
new -
!MtomMessageEncodingBindingElement @
(@ A
)A B
;B C
var 
	transport 
= 
new (
HttpsTransportBindingElement  <
(< =
)= >
;> ?
var 
customBinding 
= 
new  #
CustomBinding$ 1
(1 2
encoding2 :
,: ;
	transport< E
)E F
;F G
gusServices 
. 
Endpoint  
.  !
Binding! (
=) *
customBinding+ 8
;8 9
} 	
} 
} ª
VC:\Users\adam\source\repos\GusRestAPI\src\Application\Services\XmlResponseConverter.cs
	namespace 	
Application
 
. 
Services 
{ 
public 

class  
XmlResponseConverter %
:& '!
IXmlResponseConverter( =
{ 
public 
Task 
< 
List 
< 
T 
> 
> 
Convert $
<$ %
T% &
>& '
(' (
string( .
xmlResponse/ :
): ;
where< A
TB C
:D E
classF K
,K L
newM P
(P Q
)Q R
{ 	
using 
var 
reader 
= 
new "
StringReader# /
(/ 0
xmlResponse0 ;
); <
;< =
	XDocument 
document 
=  
	XDocument! *
.* +
Load+ /
(/ 0
reader0 6
)6 7
;7 8
var 
node 
= 
document 
.  
Descendants  +
(+ ,
$str, 2
)2 3
.3 4
ToList4 :
(: ;
); <
;< =
if 
( 
node 
!= 
null 
) 
{ 
List 
< 
T 
> 
pkds 
= 
new "
List# '
<' (
T( )
>) *
(* +
)+ ,
;, -
foreach 
( 
var  
item! %
in& (
node) -
)- .
{ 
XmlSerializer %

serializer& 0
=1 2
new3 6
XmlSerializer7 D
(D E
typeofE K
(K L
TL M
)M N
)N O
;O P
using 
var !
	xmlReader" +
=, -
new. 1
StringReader2 >
(> ?
item? C
.C D
ToStringD L
(L M
)M N
)N O
;O P
T 
result  
=! "

serializer# -
.- .
Deserialize. 9
(9 :
	xmlReader: C
)C D
asE G
TH I
??J L
newM P
TQ R
(R S
)S T
;T U
pkds   
.   
Add    
(    !
result  ! '
)  ' (
;  ( )
}!! 
return## 
Task## 
.##  

FromResult##  *
(##* +
pkds##+ /
)##/ 0
;##0 1
}$$ 
return%% 
Task%% 
.%% 

FromResult%% "
(%%" #
new%%# &
List%%' +
<%%+ ,
T%%, -
>%%- .
(%%. /
)%%/ 0
)%%0 1
;%%1 2
}&& 	
}'' 
}(( Ä
]C:\Users\adam\source\repos\GusRestAPI\src\Application\Wspolnicys\Queries\GetWspolnicyQuery.cs
	namespace 	
Application
 
. 

Wspolnicys  
.  !
Queries! (
{ 
public 

class 
GetWspolnicyQuery "
:# $
	BaseQuery% .
,. /
IRequest0 8
<8 9
List9 =
<= >
	Wspolnicy> G
>G H
>H I
{ 
public 
override 
string 
? 
NazwaRaportu  ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
=; <
$str= ^
;^ _
} 
public 

class $
GetWspolnicyQueryHandler )
:* +
IRequestHandler, ;
<; <
GetWspolnicyQuery< M
,M N
ListO S
<S T
	WspolnicyT ]
>] ^
>^ _
{ 
private 
readonly !
IXmlResponseConverter .
_responseConverter/ A
;A B
public $
GetWspolnicyQueryHandler '
(' (!
IXmlResponseConverter( =
responseConverter> O
)O P
{ 	
_responseConverter 
=  
responseConverter! 2
;2 3
} 	
public 
async 
Task 
< 
List 
< 
	Wspolnicy (
>( )
>) *
Handle+ 1
(1 2
GetWspolnicyQuery2 C
requestD K
,K L
CancellationTokenM ^
cancellationToken_ p
)p q
{ 	
try 
{ 
var   
wpolnicy   
=   
(    
await    %
request  & -
.  - .
GusServices  . 9
.  9 :'
DanePobierzPelnyRaportAsync  : U
(  U V
request  V ]
.  ] ^
Regon  ^ c
,  c d
request  e l
.  l m
NazwaRaportu  m y
)  y z
)  z {
.!! (
DanePobierzPelnyRaportResult!! 1
;!!1 2
if## 
(## 
String## 
.## 
IsNullOrEmpty## (
(##( )
wpolnicy##) 1
)##1 2
)##2 3
return##4 :
new##; >
List##? C
<##C D
	Wspolnicy##D M
>##M N
(##N O
)##O P
;##P Q
var&& 
listWspolnicy&& !
=&&" #
await&&$ )
_responseConverter&&* <
.&&< =
Convert&&= D
<&&D E
	Wspolnicy&&E N
>&&N O
(&&O P
wpolnicy&&P X
)&&X Y
;&&Y Z
return'' 
listWspolnicy'' $
;''$ %
})) 
catch** 
(** 
	Exception** 
ex** 
)**  
{++ 
Console,, 
.,, 
	WriteLine,, !
(,,! "
ex,," $
.,,$ %
Message,,% ,
),,, -
;,,- .
}-- 
return// 
new// 
(// 
)// 
;// 
}00 	
}11 
}22 