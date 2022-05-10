import React, { useEffect, useState }   from 'react';
import { MainHeader }                   from '../dumb';
import ActivityService                  from '../../service/ActivityService';
import { IEmployeeActivity }            from '../../entity/EmployeeActivity';
import StorageProvider                  from '../../provider/StorageProvider';

export const Report = () => {

  const activityDataSource : IEmployeeActivity[] = [];
  
  const ReportIn = () => <><strong role="icon">«</strong> Arriving</>;
  const ReportOut = () => <>Leaving <strong role="icon">»</strong></>;

  const [email,             setEmail]           = useState(StorageProvider.GetEmail());
  const [activities,        setActivities]      = useState(activityDataSource);

  useEffect(() => {
    ActivityService.RetrieveAsync(email)
      .then(res => setActivities(res.data as IEmployeeActivity[]));
  }, []);

  return (
    <main>

      <MainHeader prefix="Here's my " strong="activities" suffix="." />

      <table>
          <thead>
            <tr>
              <th style={{ width: "40%" }}>Email</th>
              <th style={{ width: "40%" }}>Period</th>
              <th style={{ width: "20%", textAlign: "center" }}>Action</th>
            </tr>
          </thead>
          <tbody>
            {
              activities.map(
                a => (
                  <tr key={a.id}>
                    <td>{ a.email }</td>
                    <td>{ a.period.toString().replace("T", " ") }</td>
                    <td className="text-center">
                      { a.action.toString() === "In" && <ReportIn /> }               
                      { a.action.toString() === "Out" && <ReportOut /> }
                    </td>
                  </tr>
                )
              )
            }
          </tbody>
      </table>

    </main>
  );

}