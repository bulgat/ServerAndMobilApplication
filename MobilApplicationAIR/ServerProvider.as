package 
{
	import flash.events.Event;
	import flash.events.EventDispatcher;
	import flash.events.IOErrorEvent;
	import flash.net.URLLoader;
	import flash.net.URLRequest;
	import flash.net.URLRequestHeader;
	import flash.net.URLRequestMethod;
	import flash.net.URLVariables;
	import flash.net.navigateToURL;
import flash.system.Security;
	import json.JSON;

	public class ServerProvider extends EventDispatcher
	{
		public static var COMPLETE:String = "complete";
		public static var ERROR:String = "error";

		private var _callBack:Function;
		
		public function ServerProvider() 
		{
		}
		
		public function init(pathToServer:String,callBack:Function ):void
		{
			_callBack = callBack;
			
			var urlReq:URLRequest = new URLRequest(pathToServer);

			urlReq.method = URLRequestMethod.GET;

			// отправка
			var urlLoader:URLLoader = new URLLoader();
			urlLoader.addEventListener(Event.COMPLETE, urlLoaderComplete);
			urlLoader.addEventListener(IOErrorEvent.IO_ERROR, urlLoaderIOError);
			urlLoader.load(urlReq);	
		}
		
		//запись данных на сервер
		public function initPost(requestVariables, pathToServer:String):void
		{
			
			
			
			//запись данных на сервер
			var urlVariables:URLVariables = new URLVariables();
			urlVariables = requestVariables

			var urlRequest:URLRequest = new URLRequest(pathToServer);
			urlRequest.method = URLRequestMethod.POST;
			urlRequest.data = urlVariables;

			var urlLoader:URLLoader = new URLLoader();
			urlLoader.addEventListener(Event.COMPLETE, urlLoaderComplete);
			urlLoader.addEventListener(IOErrorEvent.IO_ERROR, urlLoaderIOError);
			urlLoader.load(urlRequest);
			
		}
		
		private function urlLoaderIOError(e:IOErrorEvent):void 
		{
			trace("urlLoaderComplete --> responseObj  ERROR ");
			dispatchEvent(new Event(ServerProvider.ERROR));
		}
		
		private function urlLoaderComplete(e:Event):void 
		{
//trace("urlLoaderComplete --> "+e.target.data);
			//var k = '{"Status":"Идут регламентные работы. Причина = СКОРО","DateTime":"09.06.2016"}';
			//var statusObj:Object = JSON.decode (k);
			var statusObj1:Object = JSON.decode (e.target.data);
			
	
			
			_callBack(statusObj1);
			
			dispatchEvent(new Event(ServerProvider.COMPLETE));
		}
	}

}