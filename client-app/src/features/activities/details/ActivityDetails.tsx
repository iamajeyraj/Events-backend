import React from "react";
import { Button, Card, CardBody, CardFooter, CardHeader, CardTitle, Image } from "react-bootstrap";
import { Activity } from "../../../app/models/activity";

interface Props {
    activity: Activity
}
export default function ActivityDetails({ activity }: Props) {
    return (
        <Card>
            <Image src={`/assets/categoryImages/${activity.category}.png`} />
            <CardHeader>
                <CardTitle>{activity.title}</CardTitle>
            </CardHeader>
            <CardBody>
                <span>{activity.date}</span>
                <div className="pt-2">
                    {activity.description}
                </div>
            </CardBody>
            <CardFooter>
                <Button variant="success"> Edit </Button>
                <Button variant="danger"> Cancel </Button>
            </CardFooter>
        </Card>
    )
}