import React, { ChangeEvent, ChangeEventHandler, useState } from "react";
import { Button, Card, Col, Container, Form, FormControl, FormGroup, InputGroup, Row } from "react-bootstrap";
import InputGroupText from "react-bootstrap/esm/InputGroupText";
import { Activity } from "../../../app/models/activity";

interface Props {
    activity: Activity | undefined;
    upsertActivity: (activity:Activity) => void;
    closeForm: () => void;
}

export default function ActivityForm({ activity: selectedActivity, upsertActivity, closeForm }: Props) {
    const initialState = selectedActivity ?? {
        id: '',
        title: '',
        date: '',
        description: '',
        category: '',
        city: '',
        venue: '',
    }

    function HandleValueChange(event: ChangeEvent<HTMLInputElement>){
        const {name,value} = event.target;
        console.log(event.target.alt);
        SetActivity({...activity,[name]:value})
    }

    const [activity, SetActivity] = useState(initialState);

    return (
        <Card className="py-3 border-0 shadow">
            <Container>
                <Form>
                    <FormGroup>
                        <Form.Label>Title</Form.Label>
                        <FormControl name="title" onChange={HandleValueChange} value={activity && activity?.title}></FormControl>
                        <Form.Text className="text-muted"></Form.Text>
                    </FormGroup>
                    <FormGroup>
                        <Form.Label>Description</Form.Label>
                        <Form.Control name="description" onChange={HandleValueChange} value={activity && activity?.description} as="textarea" rows={3} />
                    </FormGroup>
                    <FormGroup>
                        <Form.Label>Category</Form.Label>
                        <FormControl name="category" onChange={HandleValueChange} value={activity && activity?.category}></FormControl>
                        <Form.Text className="text-muted"></Form.Text>
                    </FormGroup>
                    <FormGroup>
                        <Form.Label>Event Date</Form.Label>
                        <FormControl name="date" onChange={HandleValueChange} value={activity && activity?.date}></FormControl>
                        <Form.Text className="text-muted"></Form.Text>
                    </FormGroup>
                    <FormGroup>
                        <Form.Label>Event City</Form.Label>
                        <FormControl name="city" onChange={HandleValueChange} value={activity && activity?.city}></FormControl>
                        <Form.Text className="text-muted"></Form.Text>
                    </FormGroup>
                    <FormGroup>
                        <Form.Label>Event Location</Form.Label>
                        <FormControl name="location" onChange={HandleValueChange} value={activity && activity?.venue}></FormControl>
                        <Form.Text className="text-muted"></Form.Text>
                    </FormGroup>
                    <Row className="mt-3">
                        <Col md={3}>
                            <div className="">
                                <Button variant="success" onClick={()=>upsertActivity(activity)} className="align-content-end" type="submit">Sumbit</Button>
                            </div>
                        </Col>
                        <Col md={3}>
                            <div className="pl-2">
                                <Button variant="danger" onClick={closeForm} className="align-content-end">Cancel</Button>
                            </div>
                        </Col>
                    </Row>
                </Form>
            </Container>
        </Card>
    )
}