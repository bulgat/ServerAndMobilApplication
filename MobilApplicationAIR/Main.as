package {
	import flash.display.MovieClip;
	import flash.display.Sprite;
	import flash.events.*;
	import flash.geom.Point;
	import flash.events.MouseEvent;
	import flash.net.*;
	import flash.external.*;
	import flash.text.TextField;

	import flash.display.*;
	import flash.events.*;
	import flash.filters.*;
	import flash.geom.*;
	import flash.events.MouseEvent;

	public class Main extends Sprite {

		// Иницилизация
		public function Main():void {


			But.label="Обновить инфо";

			// По данному адесу, связываемся с сервером. 
			new ServerProvider().init(globParams.address,RefreshInfo);

			But.addEventListener(MouseEvent.CLICK,clickBut);


		}

		// Обновляем информацию в полях. По калл баку.
		public function RefreshInfo(obj:Object):void {

			Status.text=obj.Status.toString();
			DateTime.text=obj.DateTime.toString();
		}

		// Обновление статуса по конпке.
		public function clickBut(event:MouseEvent):void {

			new ServerProvider().init(globParams.address,RefreshInfo);
		}
	}

}