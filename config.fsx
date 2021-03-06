#load "tools/navbar.fs"

open Navbar

let menu menuItem =
    [
        menuItem "services"
        menuItem "blog"
        menuItem "contact"
        menuItem "about"
    ]

let translationByLanguage =
    dict [ ("dateFormat", 
            dict [ ("fr", "dddd d MMMM yyyy"); ("en", "dddd, MMMM d, yyyy") ])
           ("continueReading",
            dict [ ("fr", "Lire la suite..."); ("en", "continue reading...") ])
           ("postsTagged",
            dict [ ("fr", "Articles avec le label"); ("en", "Posts tagged with") ])
           ("commentsCountDefaultText",
            dict [ ("fr", "Laisser un commentaire"); ("en", "Leave a comment") ]) ]
