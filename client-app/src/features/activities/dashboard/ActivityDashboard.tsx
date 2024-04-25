import React from "react";
import { Col, Row } from "react-bootstrap";
import { Activity } from "../../../app/models/activity";
import ActivityList from "./ActivityList";
import ActivityDetails from "../details/ActivityDetails";

interface Props {
    activities: Activity[];
}

export default function ActivityDashboard({activities}: Props) {
    return (
        <Row>
            <Col md={6}>
                <ActivityList activities={activities}/>
            </Col>
            <Col md={6}>
                <ActivityDetails activity={activities[0]}/>
            </Col>
        </Row>
    )
}
