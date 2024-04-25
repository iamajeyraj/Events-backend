import React, { Fragment } from "react";
import { Activity } from "../../../app/models/activity";
import { Button, Card, CardBody, CardFooter, CardHeader, CardTitle, Col, Container, Row } from "react-bootstrap";

interface Props {
    activities: Activity[];
}

export default function ActivityList({ activities }: Props) {
    return (
        <Row>
            {activities.map(activity => (
                <Col key={activity.id} xs={75} sm={100} md={200} lg={300}>
                    <Card key={activity.id} className="pt-1 mb-2 shadow border-0 mt-4">
                        <Card.Header className="bg-primary bg-gradient text-white" >
                            <CardTitle>
                                {activity.title}
                            </CardTitle>
                        </Card.Header>
                        <Card.Subtitle className="pt-3 ms-3 text-muted">{activity.date}</Card.Subtitle>
                        <Card.Body className="d-flex flex-column">
                            <div>{activity.description}</div>
                            <div className="pt-1">{activity.city}, {activity.venue}</div>
                        </Card.Body>
                        <CardFooter>
                            <div className="d-flex justify-content-end">
                                <Button variant="primary" >View</Button>
                            </div>
                        </CardFooter>
                    </Card>
                </Col>
            ))}
        </Row>
    )
}