/*<FILE_LICENSE>
* NFX (.NET Framework Extension) Unistack Library
* Copyright 2003-2017 ITAdapter Corp. Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
</FILE_LICENSE>*/

/* Auto generated by Glue Client Compiler tool (gluec)
on 11/30/2013 11:48:24 PM at SEXTOD by Anton
Do not modify this file by hand if you plan to regenerate this file again by the tool as manual changes will be lost
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using NFX.Glue;
using NFX.Glue.Protocol;


namespace NFX.Instrumentation.Telemetry
{
  ///<summary>
  /// Client for glued contract NFX.Instrumentation.Telemetry.ITelemetryReceiver server.
  /// Each contract method has synchronous and asynchronous versions, the later denoted by 'Async_' prefix.
  /// May inject client-level inspectors here like so:
  ///   client.MsgInspectors.Register( new YOUR_CLIENT_INSPECTOR_TYPE());
  ///</summary>
  public class TelemetryReceiverClient : ClientEndPoint, NFX.Instrumentation.Telemetry.ITelemetryReceiver
  {

  #region Static Members

     private static TypeSpec s_ts_CONTRACT;
     private static MethodSpec @s_ms_Send_0;

     //static .ctor
     static TelemetryReceiverClient()
     {
         var t = typeof(NFX.Instrumentation.Telemetry.ITelemetryReceiver);
         s_ts_CONTRACT = new TypeSpec(t);
         @s_ms_Send_0 = new MethodSpec(t.GetMethod("Send", new Type[]{ typeof(@System.@String), typeof(@NFX.@Instrumentation.@Datum) }));
     }
  #endregion

  #region .ctor
     public TelemetryReceiverClient(string node, Binding binding = null) : base(node, binding) { ctor(); }
     public TelemetryReceiverClient(Node node, Binding binding = null) : base(node, binding) { ctor(); }
     public TelemetryReceiverClient(IGlue glue, string node, Binding binding = null) : base(glue, node, binding) { ctor(); }
     public TelemetryReceiverClient(IGlue glue, Node node, Binding binding = null) : base(glue, node, binding) { ctor(); }

     //common instance .ctor body
     private void ctor()
     {

     }

  #endregion

     public override Type Contract
     {
       get { return typeof(NFX.Instrumentation.Telemetry.ITelemetryReceiver); }
     }



  #region Contract Methods

         ///<summary>
         /// Synchronous invoker for  'NFX.Instrumentation.Telemetry.ITelemetryReceiver.Send'.
         /// This is a one-way call per contract specification, meaning - the server sends no acknowledgement of this call receipt and
         /// there is no result that server could return back to the caller.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         ///</summary>
         public void @Send(@System.@String  @siteName, @NFX.@Instrumentation.@Datum  @data)
         {
            var call = Async_Send(@siteName, @data);
            if (call.CallStatus != CallStatus.Dispatched)
                throw new ClientCallException(call.CallStatus, "Call failed: 'TelemetryReceiverClient.Send'");
         }

         ///<summary>
         /// Asynchronous invoker for  'NFX.Instrumentation.Telemetry.ITelemetryReceiver.Send'.
         /// This is a one-way call per contract specification, meaning - the server sends no acknowledgement of this call receipt and
         /// there is no result that server could return back to the caller.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg.
         ///</summary>
         public CallSlot Async_Send(@System.@String  @siteName, @NFX.@Instrumentation.@Datum  @data)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_Send_0, true, RemoteInstance, new object[]{@siteName, @data});
            return DispatchCall(request);
         }


  #endregion

  }//class
}//namespace
