using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001F9 RID: 505
	public class NS_Set_DoSpawnSGuest_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003CFD RID: 15613 RVA: 0x0016D6C8 File Offset: 0x0016B8C8
		// Note: this type is marked as 'beforefieldinit'.
		static NS_Set_DoSpawnSGuest_Behaviour()
		{
			Il2CppClassPointerStore<NS_Set_DoSpawnSGuest_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_Set_DoSpawnSGuest_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_Set_DoSpawnSGuest_Behaviour>.NativeClassPtr);
			NS_Set_DoSpawnSGuest_Behaviour.NativeFieldInfoPtr_shouldSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_Set_DoSpawnSGuest_Behaviour>.NativeClassPtr, "shouldSpawn");
			NS_Set_DoSpawnSGuest_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Set_DoSpawnSGuest_Behaviour>.NativeClassPtr, 100674540);
			NS_Set_DoSpawnSGuest_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Set_DoSpawnSGuest_Behaviour>.NativeClassPtr, 100674541);
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x0016D734 File Offset: 0x0016B934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137030, XrefRangeEnd = 137034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_Set_DoSpawnSGuest_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x0016D770 File Offset: 0x0016B970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_Set_DoSpawnSGuest_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_Set_DoSpawnSGuest_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_Set_DoSpawnSGuest_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x00022282 File Offset: 0x00020482
		public NS_Set_DoSpawnSGuest_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x06003D01 RID: 15617 RVA: 0x0016D7AC File Offset: 0x0016B9AC
		// (set) Token: 0x06003D02 RID: 15618 RVA: 0x0002228B File Offset: 0x0002048B
		public unsafe bool shouldSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Set_DoSpawnSGuest_Behaviour.NativeFieldInfoPtr_shouldSpawn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Set_DoSpawnSGuest_Behaviour.NativeFieldInfoPtr_shouldSpawn)) = value;
			}
		}

		// Token: 0x040028D3 RID: 10451
		private static readonly IntPtr NativeFieldInfoPtr_shouldSpawn;

		// Token: 0x040028D4 RID: 10452
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028D5 RID: 10453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
