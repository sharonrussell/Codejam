require_relative 'code'

describe Code, "#go" do
  it "returns true" do
    app = Code.new
    app.go.should eq(true)
  end
end
