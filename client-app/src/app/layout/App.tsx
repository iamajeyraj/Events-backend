import axios from "axios"
import { useEffect, useState } from "react"
import 'bootstrap/dist/css/bootstrap.min.css';
import { Container } from "react-bootstrap";
import { Activity } from "../models/activity";
import NavBar from "./Navbar";
import ActivityDashboard from "../../features/activities/dashboard/ActivityDashboard";

function App() {
  const [activities, SetActivities] = useState<Activity[]>([]);

  useEffect(() => {
    axios.get<Activity[]>("http://localhost:5000/activities")
      .then(response => {
        SetActivities(response.data)
      })
  }, [])

  return (
    <>
      <NavBar />
      <Container style={{ marginTop: '1em' }} >
        <ActivityDashboard activities={activities} />
      </Container>
    </>
  )
}


export default App
