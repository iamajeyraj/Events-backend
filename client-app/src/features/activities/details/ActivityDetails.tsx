import { Button, ButtonGroup, Card, CardBody, CardFooter, CardHeader, CardTitle, Col, Image, Row } from "react-bootstrap";
import { Activity } from "../../../app/models/activity";

interface Props {
    activity: Activity;
    cancelSelectedActivity: () => void;
    openForm:(id:string)=>void;
}
export default function ActivityDetails({ activity, cancelSelectedActivity,openForm }: Props) {
    return (
        <Card className="shadow border-0" key={activity.id}>
            <Image src={`/assets/categoryImages/${activity.category}.jpg`} />
            {/* <CardHeader>
            </CardHeader> */}
            <CardBody>
                <CardTitle >{activity.title}</CardTitle>
                <span className="text-muted">{activity.date}</span>
                <div className="pt-2">
                    {activity.description}
                </div>
            </CardBody>
            <CardFooter>
                <Row >
                    <Col md={2}>
                        <div className="col-xs-2">
                            <Button variant="success" onClick={()=>openForm(activity.id)} className="align-content-end" type="submit">Edit</Button>
                        </div>
                    </Col>
                    <Col md={2}>
                        <div className="col-xs-2">
                            <Button variant="danger" onClick={cancelSelectedActivity} className="align-content-end">Cancel</Button>
                        </div>
                    </Col>
                </Row>
            </CardFooter>
        </Card>
    )
}