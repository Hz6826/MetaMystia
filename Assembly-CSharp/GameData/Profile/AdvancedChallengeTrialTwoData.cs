using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace GameData.Profile
{
	// Token: 0x020002F3 RID: 755
	public class AdvancedChallengeTrialTwoData : GeneralTrialChallengeBossData
	{
		// Token: 0x06005A69 RID: 23145 RVA: 0x00030DB6 File Offset: 0x0002EFB6
		// Note: this type is marked as 'beforefieldinit'.
		static AdvancedChallengeTrialTwoData()
		{
			Il2CppClassPointerStore<AdvancedChallengeTrialTwoData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "AdvancedChallengeTrialTwoData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedChallengeTrialTwoData>.NativeClassPtr);
			AdvancedChallengeTrialTwoData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedChallengeTrialTwoData>.NativeClassPtr, 100681433);
		}

		// Token: 0x06005A6A RID: 23146 RVA: 0x001CD46C File Offset: 0x001CB66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219883, XrefRangeEnd = 219884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedChallengeTrialTwoData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedChallengeTrialTwoData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedChallengeTrialTwoData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A6B RID: 23147 RVA: 0x00030DEF File Offset: 0x0002EFEF
		public AdvancedChallengeTrialTwoData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003C2C RID: 15404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
