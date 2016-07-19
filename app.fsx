#r @"Suave\lib\net40\Suave.dll" ;;

open Suave ;;
open Suave.Operators ;;
open Suave.Filters ;;
open Suave.Redirection ;;

let app =
    choose
        [ path "/g" >=> redirect "http://www.google.com/" ;
          path "/md" >=> redirect "http://www.md-techblog.net.pl/" ] ;;

let config = 
    { defaultConfig with
       bindings = [ HttpBinding.mkSimple HTTP "0.0.0.0" 80 ]
    } ;;

startWebServer config app ;;
