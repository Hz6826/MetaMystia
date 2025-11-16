using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000E6 RID: 230
	public class DLC5_RogueLikeCardMoreFish : DLC5_RogueLikeCardGiveItemAfterSettle
	{
		// Token: 0x06001AC6 RID: 6854 RVA: 0x000F7C08 File Offset: 0x000F5E08
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardMoreFish()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardMoreFish>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardMoreFish");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreFish>.NativeClassPtr);
			DLC5_RogueLikeCardMoreFish.NativeMethodInfoPtr_get_TypeIndex_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreFish>.NativeClassPtr, 100668109);
			DLC5_RogueLikeCardMoreFish.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreFish>.NativeClassPtr, 100668110);
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x000F7C60 File Offset: 0x000F5E60
		public unsafe override int TypeIndex
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardMoreFish.NativeMethodInfoPtr_get_TypeIndex_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x000F7CA8 File Offset: 0x000F5EA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardMoreFish() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreFish>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardMoreFish.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x0001081A File Offset: 0x0000EA1A
		public DLC5_RogueLikeCardMoreFish(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIndex_Protected_Virtual_get_Int32_0;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
