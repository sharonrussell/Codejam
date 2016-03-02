describe("Code", function() {

	var code = new Code();

	describe("Go", function(){
		it("should return true", function() {
			var result = code.go();
			expect(result).toBeTruthy();
		});
	});
});