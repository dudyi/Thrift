namespace csharp ThriftClassLibrary

service SampleService {
    ServiceVersion GetVersion()
    list<string> SayHello(1: string name)
}

struct ServiceVersion {
    1: required string name;
    2: required string version;
}