import React from "react";
import { Col, Row } from "react-bootstrap";
import { Activity } from "../../../app/models/activity";
import ActivityList from "./ActivityList";

interface Props {
    activities: Activity[];
}

export default function ActivityDashboard({activities}: Props) {
    return (
        <Row>
            <Col xs={6}>
                <ActivityList activities={activities}/>
            </Col>
        </Row>
    )
}
