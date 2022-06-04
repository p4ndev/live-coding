import { Component, OnInit } from '@angular/core';
import { DemoServices } from 'src/shared/services/demo.services';

@Component({
  selector:     'app-chat',
  templateUrl:  './chat.component.html',
  styleUrls:    ['./chat.component.sass']
})
export class ChatComponent implements OnInit {

  connectionId?   : string;
  clientMessage?  : string;

  constructor(public hub : DemoServices) {
    this.FillMessage("Fetching...");
    this.connectionId = "00000-000000-000000";
  }

  ngOnInit(){ this.hub.GetConnection().on("DisplayMessage", this.FillMessage); }

  private FillMessage       = (item : string) => this.clientMessage = item;
  private FillConnectionId  = ()              => this.connectionId  = this.hub.GetConnection().connectionId?.toString();

  public Fetch(){
    this.FillConnectionId();
    this.hub.GetConnection().invoke("Hello");
  }

}