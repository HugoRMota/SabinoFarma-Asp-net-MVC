!function(m){"use strict";var a={cntClass:"map",mapClass:"map_model",locationsClass:"map_locations",marker:{basic:"/Imagens/gmap_marker.png",active:"/Imagens/gmap_marker_active.png"},styles:[{featureType:"landscape",stylers:[{saturation:-100},{lightness:65},{visibility:"on"}]},{featureType:"poi",stylers:[{saturation:-100},{lightness:51},{visibility:"simplified"}]},{featureType:"road.highway",stylers:[{saturation:-100},{visibility:"simplified"}]},{featureType:"road.arterial",stylers:[{saturation:-100},{lightness:30},{visibility:"on"}]},{featureType:"road.local",stylers:[{saturation:-100},{lightness:40},{visibility:"on"}]},{featureType:"transit",stylers:[{saturation:-100},{visibility:"simplified"}]},{featureType:"administrative.province",stylers:[{visibility:"off"}]},{featureType:"water",elementType:"labels",stylers:[{visibility:"on"},{lightness:-25},{saturation:-100}]},{featureType:"water",elementType:"geometry",stylers:[{hue:"#ffff00"},{lightness:-25},{saturation:-97}]}]},y={map:{x:-41.153996,y:-20.84489,zoom:16},locations:[]};m.fn.googleMap=function(p){p=m.extend(!0,{},a,p),m(this).each(function(){var a,e,t,i,s=m(this),o=m.extend(!0,{},y,{map:{x:s.data("x"),y:s.data("y"),zoom:s.data("zoom")},locations:(a=s,e=p,t=a.parent().find("."+e.locationsClass).find("li"),i=[],0<t.length&&t.each(function(a){var t=m(this);t.data("x")&&t.data("y")&&(i[a]={x:t.data("x"),y:t.data("y"),basic:t.data("basic")?t.data("basic"):e.marker.basic,active:t.data("active")?t.data("active"):e.marker.active},m.trim(t.html())?i[a].content='<div class="iw-content">'+t.html()+"</div>":i[a].content=!1)}),i)}),n=new google.maps.Map(this,{center:new google.maps.LatLng(parseFloat(o.map.y),parseFloat(o.map.x)),scrollwheel:!1,styles:p.styles,zoom:o.map.zoom}),l=new google.maps.InfoWindow,r=[];for(var c in o.locations)r[c]=new google.maps.Marker({position:new google.maps.LatLng(parseFloat(o.locations[c].y),parseFloat(o.locations[c].x)),map:n,icon:o.locations[c].basic,index:c}),o.locations[c].content&&(google.maps.event.addListener(r[c],"click",function(){for(var a in r)r[a].setIcon(o.locations[a].basic);l.setContent(o.locations[this.index].content),l.open(n,this),m(".gm-style-iw").parent().parent().addClass("gm-wrapper"),this.setIcon(o.locations[this.index].active)}),google.maps.event.addListener(l,"closeclick",function(){for(var a in r)r[a].setIcon(o.locations[a].basic)}));google.maps.event.addDomListener(window,"resize",function(){n.setCenter(new google.maps.LatLng(parseFloat(o.map.y),parseFloat(o.map.x)))})})}}(jQuery);