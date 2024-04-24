import axios from "axios"
import { useEffect, useState } from "react"
import 'bootstrap/dist/css/bootstrap.min.css';
import { ListGroup, ListGroupItem, Navbar } from "react-bootstrap";
import { Activity } from "../models/activity";
import NavBar from "./Navbar";

function App() {
  const [activities, SetActivities] = useState<Activity[]>([]);

  useEffect(()=>{
    axios.get<Activity[]>("http://localhost:5000/activities")
      .then(response => {
        SetActivities(response.data) 
      })
  }, [])
  
  return (
      <div>
        <NavBar/>
        <ul>
          {
            activities.map((activity)=>(
              <div>
                {/* <ListGroup> */}
                  <ListGroupItem>
                    {activity.title}
                  </ListGroupItem>
                {/* </ListGroup> */}
              </div>
            ))
          }
        </ul>
      </div>
  )
}


export default App
