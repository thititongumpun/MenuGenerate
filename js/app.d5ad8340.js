(function(t){function e(e){for(var o,s,u=e[0],i=e[1],c=e[2],p=0,f=[];p<u.length;p++)s=u[p],Object.prototype.hasOwnProperty.call(r,s)&&r[s]&&f.push(r[s][0]),r[s]=0;for(o in i)Object.prototype.hasOwnProperty.call(i,o)&&(t[o]=i[o]);l&&l(e);while(f.length)f.shift()();return a.push.apply(a,c||[]),n()}function n(){for(var t,e=0;e<a.length;e++){for(var n=a[e],o=!0,u=1;u<n.length;u++){var i=n[u];0!==r[i]&&(o=!1)}o&&(a.splice(e--,1),t=s(s.s=n[0]))}return t}var o={},r={app:0},a=[];function s(e){if(o[e])return o[e].exports;var n=o[e]={i:e,l:!1,exports:{}};return t[e].call(n.exports,n,n.exports,s),n.l=!0,n.exports}s.m=t,s.c=o,s.d=function(t,e,n){s.o(t,e)||Object.defineProperty(t,e,{enumerable:!0,get:n})},s.r=function(t){"undefined"!==typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(t,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(t,"__esModule",{value:!0})},s.t=function(t,e){if(1&e&&(t=s(t)),8&e)return t;if(4&e&&"object"===typeof t&&t&&t.__esModule)return t;var n=Object.create(null);if(s.r(n),Object.defineProperty(n,"default",{enumerable:!0,value:t}),2&e&&"string"!=typeof t)for(var o in t)s.d(n,o,function(e){return t[e]}.bind(null,o));return n},s.n=function(t){var e=t&&t.__esModule?function(){return t["default"]}:function(){return t};return s.d(e,"a",e),e},s.o=function(t,e){return Object.prototype.hasOwnProperty.call(t,e)},s.p="/FoodGenerate/";var u=window["webpackJsonp"]=window["webpackJsonp"]||[],i=u.push.bind(u);u.push=e,u=u.slice();for(var c=0;c<u.length;c++)e(u[c]);var l=i;a.push([0,"chunk-vendors"]),n()})({0:function(t,e,n){t.exports=n("56d7")},"034f":function(t,e,n){"use strict";n("85ec")},"56d7":function(t,e,n){"use strict";n.r(e);n("e260"),n("e6cf"),n("cca6"),n("a79d");var o=n("2b0e"),r=function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("div",{attrs:{id:"app"}},[n("v-toolbar",{attrs:{rounded:""}},[n("v-btn",{attrs:{text:"",to:"/"}},[t._v("Home")]),n("v-spacer"),n("v-toolbar-items",{staticClass:"hidden-sm-and-down"},[n("v-btn",{attrs:{text:"",to:"/foodgenerate"}},[t._v("Random")]),n("v-btn",{attrs:{text:"",to:"/ranking"}},[t._v("Ranking")])],1)],1),n("v-main",[n("router-view")],1)],1)},a=[],s={name:"App",components:{}},u=s,i=(n("034f"),n("2877")),c=n("6544"),l=n.n(c),p=n("8336"),f=n("f6c4"),d=n("2fa4"),v=n("71d9"),m=n("2a7f"),h=Object(i["a"])(u,r,a,!1,null,null,null),b=h.exports;l()(h,{VBtn:p["a"],VMain:f["a"],VSpacer:d["a"],VToolbar:v["a"],VToolbarItems:m["a"]});var _=n("8c4f"),g=n("bc3a"),y=n.n(g),O=n("2f62");o["a"].use(O["a"]);var w={posts:[]},P={},S={getPosts:function(t){var e=t.commit;y.a.get("https://jsonplaceholder.typicode.com/posts").then((function(t){e("SET_POSTS",t.data)}))}},j={SET_POSTS:function(t,e){t.posts=e}},x=new O["a"].Store({state:w,getters:P,actions:S,mutations:j}),T=n("f309");o["a"].use(T["a"]);var k=new T["a"]({}),$=function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("div",[n("h1",[t._v(t._s(t.msg))])])},E=[],V={data:function(){return{msg:"Home Page"}}},M=V,H=Object(i["a"])(M,$,E,!1,null,null,null),R=H.exports,X=function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("div",[n("h1",[t._v("Hello From "+t._s(t.title))])])},B=[],C={data:function(){return{title:"Welcome to Ranking Page"}}},F=C,J=Object(i["a"])(F,X,B,!1,null,null,null),W=J.exports,A=function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("div",{staticClass:"hello"},[n("h1",[t._v(t._s(t.msg)+" ")]),t._l(t.posts,(function(e){return n("div",{key:e.id},[n("h3",[t._v("Post Title: ")]),t._v(" "+t._s(e.title)+" "),n("h3",[t._v("Post Body: ")]),t._v(t._s(e.body)+" ")])}))],2)},G=[],I={name:"myStore",data:function(){return{msg:"Welcome to my VuexXXX Store"}},computed:{posts:function(){return this.$store.state.posts}},mounted:function(){this.$store.dispatch("getPosts")}},q=I,z=Object(i["a"])(q,A,G,!1,null,null,null),D=z.exports;o["a"].config.productionTip=!1,o["a"].use(_["a"]);var K=new _["a"]({mode:"history",routes:[{path:"",component:R},{path:"/foodgenerate",component:D},{path:"/ranking",component:W}]});new o["a"]({store:x,router:K,vuetify:k,render:function(t){return t(b)}}).$mount("#app")},"85ec":function(t,e,n){}});
//# sourceMappingURL=app.d5ad8340.js.map