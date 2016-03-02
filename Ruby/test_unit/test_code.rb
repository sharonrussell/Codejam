require_relative 'Code'
require 'test/unit'

class TestCode < Test::Unit::TestCase
	def test_go
		app = Code.new
		assert(app.go)
	end
end