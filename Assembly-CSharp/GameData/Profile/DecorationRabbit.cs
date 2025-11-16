using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using NightScene.EventUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x0200030F RID: 783
	public class DecorationRabbit : DecorationBase
	{
		// Token: 0x06005D28 RID: 23848 RVA: 0x001D45A4 File Offset: 0x001D27A4
		// Note: this type is marked as 'beforefieldinit'.
		static DecorationRabbit()
		{
			Il2CppClassPointerStore<DecorationRabbit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DecorationRabbit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecorationRabbit>.NativeClassPtr);
			DecorationRabbit.NativeFieldInfoPtr_freeCookRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationRabbit>.NativeClassPtr, "freeCookRate");
			DecorationRabbit.NativeFieldInfoPtr_rabbitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationRabbit>.NativeClassPtr, "rabbitOffset");
			DecorationRabbit.NativeFieldInfoPtr_rabbitParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationRabbit>.NativeClassPtr, "rabbitParent");
			DecorationRabbit.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationRabbit>.NativeClassPtr, 100682495);
			DecorationRabbit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationRabbit>.NativeClassPtr, 100682496);
		}

		// Token: 0x06005D29 RID: 23849 RVA: 0x001D4638 File Offset: 0x001D2838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232865, XrefRangeEnd = 232910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DecorationBuffEnterNight(EventManager eventManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecorationRabbit.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D2A RID: 23850 RVA: 0x001D4688 File Offset: 0x001D2888
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecorationRabbit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecorationRabbit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationRabbit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D2B RID: 23851 RVA: 0x00032D57 File Offset: 0x00030F57
		public DecorationRabbit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x06005D2C RID: 23852 RVA: 0x001D46C4 File Offset: 0x001D28C4
		// (set) Token: 0x06005D2D RID: 23853 RVA: 0x00032D60 File Offset: 0x00030F60
		public unsafe float freeCookRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationRabbit.NativeFieldInfoPtr_freeCookRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationRabbit.NativeFieldInfoPtr_freeCookRate)) = value;
			}
		}

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x06005D2E RID: 23854 RVA: 0x001D46EC File Offset: 0x001D28EC
		// (set) Token: 0x06005D2F RID: 23855 RVA: 0x00032D7B File Offset: 0x00030F7B
		public unsafe Vector2 rabbitOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationRabbit.NativeFieldInfoPtr_rabbitOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationRabbit.NativeFieldInfoPtr_rabbitOffset)) = value;
			}
		}

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x06005D30 RID: 23856 RVA: 0x001D4714 File Offset: 0x001D2914
		// (set) Token: 0x06005D31 RID: 23857 RVA: 0x00032D96 File Offset: 0x00030F96
		public unsafe GameObject rabbitParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationRabbit.NativeFieldInfoPtr_rabbitParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationRabbit.NativeFieldInfoPtr_rabbitParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003DA7 RID: 15783
		private static readonly IntPtr NativeFieldInfoPtr_freeCookRate;

		// Token: 0x04003DA8 RID: 15784
		private static readonly IntPtr NativeFieldInfoPtr_rabbitOffset;

		// Token: 0x04003DA9 RID: 15785
		private static readonly IntPtr NativeFieldInfoPtr_rabbitParent;

		// Token: 0x04003DAA RID: 15786
		private static readonly IntPtr NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0;

		// Token: 0x04003DAB RID: 15787
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D2D RID: 3373
		[ObfuscatedName("GameData.Profile.DecorationRabbit+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F304 RID: 62212 RVA: 0x00398E58 File Offset: 0x00397058
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DecorationRabbit.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecorationRabbit>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecorationRabbit.__c__DisplayClass3_0>.NativeClassPtr);
				DecorationRabbit.__c__DisplayClass3_0.NativeFieldInfoPtr_rabbitSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationRabbit.__c__DisplayClass3_0>.NativeClassPtr, "rabbitSprite");
				DecorationRabbit.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationRabbit.__c__DisplayClass3_0>.NativeClassPtr, 100682497);
				DecorationRabbit.__c__DisplayClass3_0.NativeMethodInfoPtr__DecorationBuffEnterNight_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationRabbit.__c__DisplayClass3_0>.NativeClassPtr, 100682498);
			}

			// Token: 0x0600F305 RID: 62213 RVA: 0x00398EC0 File Offset: 0x003970C0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecorationRabbit.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationRabbit.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F306 RID: 62214 RVA: 0x00398EFC File Offset: 0x003970FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232861, XrefRangeEnd = 232865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DecorationBuffEnterNight_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationRabbit.__c__DisplayClass3_0.NativeMethodInfoPtr__DecorationBuffEnterNight_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F307 RID: 62215 RVA: 0x00082789 File Offset: 0x00080989
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F07 RID: 20231
			// (get) Token: 0x0600F308 RID: 62216 RVA: 0x00398F30 File Offset: 0x00397130
			// (set) Token: 0x0600F309 RID: 62217 RVA: 0x00082792 File Offset: 0x00080992
			public unsafe SpriteRenderer rabbitSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationRabbit.__c__DisplayClass3_0.NativeFieldInfoPtr_rabbitSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationRabbit.__c__DisplayClass3_0.NativeFieldInfoPtr_rabbitSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009AD0 RID: 39632
			private static readonly IntPtr NativeFieldInfoPtr_rabbitSprite;

			// Token: 0x04009AD1 RID: 39633
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AD2 RID: 39634
			private static readonly IntPtr NativeMethodInfoPtr__DecorationBuffEnterNight_b__0_Internal_Void_0;
		}
	}
}
