using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000EA RID: 234
	public class DLC5_RogueLikeCardMoreOther : DLC5_RogueLikeCardGiveItemAfterSettle
	{
		// Token: 0x06001AE2 RID: 6882 RVA: 0x000F835C File Offset: 0x000F655C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardMoreOther()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardMoreOther>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardMoreOther");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreOther>.NativeClassPtr);
			DLC5_RogueLikeCardMoreOther.NativeMethodInfoPtr_get_TypeIndex_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreOther>.NativeClassPtr, 100668138);
			DLC5_RogueLikeCardMoreOther.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreOther>.NativeClassPtr, 100668139);
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x000F83B4 File Offset: 0x000F65B4
		public unsafe override int TypeIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardMoreOther.NativeMethodInfoPtr_get_TypeIndex_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x000F83FC File Offset: 0x000F65FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardMoreOther() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreOther>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardMoreOther.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x00010897 File Offset: 0x0000EA97
		public DLC5_RogueLikeCardMoreOther(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIndex_Protected_Virtual_get_Int32_0;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
