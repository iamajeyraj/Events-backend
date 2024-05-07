import { Activity } from "../../../app/models/activity";
import { Badge, Button, Card, CardFooter, CardTitle, Col, Row } from "react-bootstrap";

interface Props {
    activities: Activity[];
    selectActivity: (id: string) => void;
    deleteActivity: (id: string) => void;
}

export default function ActivityList({ activities,
    selectActivity, deleteActivity }: Props) {
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
                            <div>
                                <Badge bg="success">{activity.category}</Badge>
                            </div>
                        </Card.Body>

                        <CardFooter>
                            <div className="d-flex justify-content-end">
                                <Button variant="primary" className="mx-2" onClick={() => selectActivity(activity.id)}>View</Button>
                                <Button variant="danger" onClick={() => deleteActivity(activity.id)}>Delete</Button>
                            </div>
                        </CardFooter>
                    </Card>
                </Col>
            ))}
        </Row>
    )
}