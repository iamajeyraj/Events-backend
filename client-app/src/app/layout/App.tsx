import axios from "axios"
import { useEffect, useState } from "react"
import 'bootstrap/dist/css/bootstrap.min.css';
import { Container } from "react-bootstrap";
import { Activity } from "../models/activity";
import NavBar from "./Navbar";
import ActivityDashboard from "../../features/activities/dashboard/ActivityDashboard";
import { v4 as uuid } from "uuid";

function App() {
  const [activities, SetActivities] = useState<Activity[]>([]);
  const [selectedActivity, SetSelectedActivity] = useState<Activity | undefined>(undefined);
  const [editMode, SetEditMode] = useState(false);

  useEffect(() => {
    axios.get<Activity[]>("http://localhost:5000/activities")
      .then(response => {
        SetActivities(response.data)
      })
  }, [])

  function HandleSelectActivity(id: string) {
    SetSelectedActivity(activities.find(x => x.id == id))
  }

  function HandlerCancelSelectedActivity() {
    SetSelectedActivity(undefined);
  }

  function HandleDeleteActivity(id: string) {
    SetActivities([...activities.filter(x => x.id != id)])
  }

  function UpsertActivity(activity: Activity) {
    console.log(activity.id)
    activity.id ? SetActivities([...activities.filter(x => x.id === activity.id), activity]) :
      SetActivities([...activities, { ...activity, id: uuid() }]);
    SetSelectedActivity(activity);
    SetEditMode(false);
  }

  function HandleFormOpen(id: string) {
    id ? HandleSelectActivity(id) : HandlerCancelSelectedActivity();
    SetEditMode(true);
  }

  function HandlerFormClose() {
    SetEditMode(false);
  }

  return (
    <>
      <NavBar openform={HandleFormOpen} />
      <Container style={{ marginTop: '1em' }} >
        <ActivityDashboard activities={activities}
          selectedActivity={selectedActivity}
          selectActivity={HandleSelectActivity}
          cancelSelectedActivity={HandlerCancelSelectedActivity}
          editMode={editMode}
          openForm={HandleFormOpen}
          closeForm={HandlerFormClose}
          upsertActivity={UpsertActivity}
          deleteActivity={HandleDeleteActivity}
        />
      </Container>
    </>
  )
}


export default App
