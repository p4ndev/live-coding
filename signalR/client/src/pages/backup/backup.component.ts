import { Component, OnInit } from '@angular/core';
import { ISnapshot } from 'src/shared/data/ISnapshot.dto';
import { DemoServices } from 'src/shared/services/demo.services';

@Component({
  selector:     'app-backup',
  templateUrl:  './backup.component.html',
  styleUrls:    ['./backup.component.sass']
})
export class BackupComponent implements OnInit {

  snapshotIDs : ISnapshot[] = [];
  currentConnectionId : string = "";

  constructor(public hub : DemoServices) { }

  ngOnInit() {    
    this.hub.GetConnection().on("SnapshotBroadcast", (stream : ISnapshot) => this.snapshotIDs.push(stream));
    this.hub.GetConnection().invoke("Backup");
    this.currentConnectionId = this.hub.GetConnection().connectionId!;
  }

}
